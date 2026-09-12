"""The 22 licensable ERP modules, plus the layout of the feature group box."""

from collections import namedtuple

# Both GetFn and GetFnAndQty in the original index into a 32-slot table by the
# same number: GetFn flips slot `index` of a 32-character bit string to '1',
# GetFnAndQty emits FEATURE_TAGS[index] followed by the module's user count.
FEATURE_TAGS = "mjpdruebwynkatqf~!@#$%^&*(){}=+?"

FEATURE_BITS = 32

Module = namedtuple("Module", "code label index tooltip")


def _module(code, label, index, tooltip):
    return Module(code, label, index, tooltip)


# Listed in ascending index order, which is also the order GetFnAndQty
# concatenates the selected modules in.
MODULES = (
    _module("YSF", "应收应付", 2, "YSF 应收应付"),
    _module("PJM", "票据资金", 3, "PJM 票据资金"),
    _module("KJS", "会计总账", 4, "KJS 会计总账"),
    _module("RGS", "报表生成", 5, "RGS 报表生成"),
    _module("SGM", "生产管理", 6, "SGM 生产管理"),
    _module("CRM", "客户关系", 7, "CRM 客户关系"),
    _module("GZS", "工资", 8, "GZS 工资"),
    _module("ZCS", "资产", 9, "ZCS 资产"),
    _module("SXM", "物料需求", 10, "SXM 物料需求"),
    _module("SCM", "生产成本", 11, "SCM 生产成本"),
    _module("GYS", "工单工艺", 12, "GYS 工单工艺"),
    _module("JCA", "营业决策", 13, "JCA 营业决策"),
    _module("CWB", "财务报表平台", 14, "CWB 财务报表平台"),
    _module("COP", "销售", 15, "COP 销售"),
    _module("PUR", "采购", 16, "PUR 采购"),
    _module("INV", "存货", 17, "INV 存货"),
    _module("WLB", "物流包", 18, "WLB 物流包(销售/采购/存货)"),
    _module("FIB", "财务包", 19, "FIB 财务包(会计总帐/应收应付)"),
    _module("SYS", "系统包", 20, "SYS 系统包（销售/采购/存货/生管/物料需求/应收应付/报表生成）"),
    _module("BAS", "基础包", 21, "BAS 基础包（销售/采购/存货/应收应付/报表生成）"),
    _module("QMS", "检验管理", 22, "QMS 检验管理"),
    _module("RMA", "服务管理", 23, "RMA 服务管理"),
)

MODULES_BY_CODE = {module.code: module for module in MODULES}

# Sentinel for the "所有功能" check box, which is not a module of its own.
ALL_CODE = "ALL"
ALL_LABEL = "所有功能"
ALL_TOOLTIP = "所有功能"

# Reading order of the feature group box, column by column, as laid out in
# Form1.Designer.cs.
COLUMNS = (
    ("BAS", "FIB", "JCA", "QMS", "SGM", "YSF"),
    ("COP", "GYS", "KJS", "RGS", "SXM", "ZCS"),
    ("CRM", "GZS", "PJM", "RMA", "SYS", ALL_CODE),
    ("CWB", "INV", "PUR", "SCM", "WLB"),
)
