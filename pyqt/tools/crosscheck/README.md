# 与原版 exe 对拍

这套脚本把 PyQt 版算法（`keygen/core.py`）与原版 `TPA.exe`（即根目录
`直接下载可用-易助 5.0-KeyGen.exe`，两者逐字节相同）逐例对拍，序列号与验证口令
都要完全一致。

## 文件

| 文件 | 作用 |
| --- | --- |
| `cases.json` | 测试用例（客户代号 / 安装代号 / 公司名 / 勾选模块 / 用户数），覆盖各种边界 |
| `run_exe.ps1` | 驱动真正的 `TPA.exe`：加载程序集、实例化 `Form1`、填入参数、调用 `Button1_Click`，把序列号/口令连同点击时的实际控件状态写入 `exe_results.json` |
| `compare.py` | 用同样的输入跑 `keygen.core`，与 `exe_results.json` 对比 |
| `exe_results.json` | 由 `run_exe.ps1` 生成（未纳入版本控制） |

## 运行

需要 **Windows + .NET Framework**（原版是 VB WinForms 程序）。

```powershell
powershell -ExecutionPolicy Bypass -File run_exe.ps1
```

```bash
python compare.py
```

`compare.py` 退出码为 0 表示全部一致。`keygen.core` 是纯 Python，跑对比无需安装 PyQt。

## 注意事项

* **编码。** 原版用 `Encoding.Default`（系统 ANSI 代码页）编码公司名。要让含中文的
  公司名与本移植（硬编码 GBK / 936）一致，运行 exe 的机器「非 Unicode 程序的语言」
  必须是中文（代码页 936）。纯 ASCII 公司名在任何区域都一致。
* **不要 `Show()` 窗体。** 原版把复选框状态通过 `My.Settings` 做了数据绑定，绑定会在
  `Load` 事件时回读并覆盖我们设置的值。`run_exe.ps1` 因此只构造窗体、不显示。
* **控件是属性不是字段。** dnSpy 反编译出的 VB `WithEvents` 控件是 `internal virtual`
  属性（backing field `_名字`），反射时用 `GetProperty`。

## 结论

2026-09-12 在代码页 936 环境下跑过一次，`cases.json` 全部 15 例的序列号与验证口令
均与原版 exe 完全一致。
