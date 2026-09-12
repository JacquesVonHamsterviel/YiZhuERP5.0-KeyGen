# 易助 5.0 KeyGen — PyQt 版


可在 macOS / Linux / Windows 上运行，不再需要 .NET Framework 4.0。

## 运行

```bash
pip install -r requirements.txt
```

```bash
python3 main.py
```

## 测试

```bash
python3 -m unittest discover -s tests
```

## 代码结构

| 文件 | 对应原文件 | 内容 |
| --- | --- | --- |
| `keygen/vbcompat.py` | `Microsoft.VisualBasic` | `Left` / `Right` / `Mid` / `Val` / `Format` / `Encoding.Default` |
| `keygen/modules.py` | `Form1.Designer.cs` | 22 个模块的代号、名称、功能位下标、提示文字、界面排布 |
| `keygen/core.py` | `Form1.cs` | 算法本体，不依赖 Qt |
| `keygen/ui.py` | `Form1.Designer.cs` | 窗口界面与事件 |

`core.py` 与原方法的对应关系：

| Python | C# |
| --- | --- |
| `generate()` | `Button1_Click` |
| `get_rol()` | `GetROL` |
| `get_qty()` | `GetQty` |
| `get_fn()` | `GetFn` |
| `get_fn_and_qty()` | `GetFnAndQty` |
| `md5_hash()` | `getMd5Hash` |
| `d_to_b()` / `b_to_h()` / `h_to_b()` | 同名方法 |

## 算法要点

序列号由 `-` 连接的若干段组成：

```
客户代号 - 用户数 - 功能位图 - 各模块用户数 - @@@2 - %%%公司名变换 - 校验和
```

勾选「所有功能」时，功能位图固定为 `ffffffff`，并且「各模块用户数」这一段整段不出现
（它仍参与哈希，但此时为空串）。

* **功能位图**：32 位字符串，每个模块占固定下标（`YSF`=2 … `RMA`=23），选中置 `1`，
  再转成 8 位十六进制。
* **各模块用户数**：按下标升序，每个选中模块输出 `FEATURE_TAGS[下标]` 加两位用户数。
* **公司名变换**（`GetROL`）：把公司名按系统 ANSI 编码取字节，第 *i* 个字节（从 1 计）
  循环右移 `i mod 8` 位，输出两位大写十六进制。因此一个汉字贡献 4 个字符。
* **校验和**：把上述各段按「奇数段取首字符、偶数段取末字符」拼成种子，对种子做一次
  `GetROL`，再对「各段原文 + 种子」求 MD5，取前 8 位。
* **验证口令**：同样的流程，但参与拼接的还有校验和与安装代号，取 MD5 的第 9–16 位。

## 与原版的差异

* **安装代号允许为空。** 原版会弹「请输入安装代号」并直接返回。但它比较的是未 trim 的
  `SN.Text`，所以填几个空格本来就能过关，而后续参与哈希的是 `SN.Text.Trim()`，此时又
  变回空串。也就是说原版拦得住空串却拦不住空白串，两者本该同解。这里直接去掉了这项
  校验，留空得到的结果与原版填空格时完全一致。客户代号仍为必填。
* **窗口可缩放。** 原版是 `FormBorderStyle.FixedDialog` 加固定的 643×610 像素布局。
  由于各平台字体度量不同，这里改用 Qt 布局管理器，窗口可自由缩放。
* **不再保存勾选状态。** 原版用 `My.Settings` 把每个复选框的状态绑定到用户配置文件。
  Qt 没有等价机制，这里每次启动都是空白状态。
* **`StrEncrypt` 未移植。** 原方法把参数转成一个 `Byte` 后直接返回空串，是死代码，
  且没有任何调用点。
* **编码。** `Encoding.Default` 在原运行环境（中文 Windows）下是 GBK / 代码页 936，
  这里硬编码为 `vbcompat.ANSI_CODEPAGE = "gbk"`。若原本运行在别的区域设置上，
  含非 ASCII 的公司名会得到不同结果。

## 验证到什么程度

**已与原版 exe 逐例对拍通过。** 2026-09-12 在 Windows（系统 ANSI 代码页 936 / GBK）
上，用原版 `TPA.exe`（即根目录 `直接下载可用-易助 5.0-KeyGen.exe`，两者逐字节相同）
跑了 15 组输入，序列号与验证口令**全部完全一致**，覆盖：中文公司名（GBK 编码）、
「所有功能」模式、安装代号留空、用户数求和进位到三位、`Val` 怪癖（`"1 0"`→10、
`"ab"`→0）、`Format` 四舍五入（2.5→3）、不选/空模块、高下标模块标签、一次勾选全部
22 个模块等。对拍脚本见 [`tools/crosscheck/`](tools/crosscheck/)（`run_exe.ps1` 驱动
真正的 exe，`compare.py` 用相同输入跑 `keygen.core` 并比对）。

对拍之外的辅助验证：

1. 逐行对照 C# 源码翻译，VB 运行时函数单独实现并测试（`Right(s, 0)` 返回空串、
   `Mid` 从 1 开始、`Val` 忽略中间空格、`Format(n, "00")` 超过两位时不截断等）。
2. `GetROL` 与用整数移位独立写的实现逐字节比对，并手工核算过 `测试公司` 的 GBK
   字节（`b2 e2 ca d4 b9 ab cb be` → `59B8594DCDAE97BE`）。
3. `GetFn` 与用整数掩码独立写的实现比对。
4. `tests/test_keygen.py::test_regression_lock` 固定了一组输出防止回归，其值
   （`ABC123-…-571ae90f` / `65cf3a6c`）已由上述对拍确认与原版一致。

> 提醒：对拍是在代码页 936 的机器上完成的。若在「非 Unicode 程序语言」不是中文的
> 系统上运行原版 exe，含中文的公司名会与本移植不同（见上文「编码」一节）；纯 ASCII
> 公司名不受影响。

## 许可

原项目见仓库根目录的 `LICENSE` 与 `README.md`。
