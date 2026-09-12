# -*- coding: utf-8 -*-
"""Diff keygen.core against the original exe.

Reads exe_results.json (produced by run_exe.ps1), feeds the exact control state
the exe used into keygen.core, and checks that both the serial (KEY) and the
verification password (PW) come out identical.

    python compare.py

Exit code 0 = every case matched, 1 = at least one mismatch.  keygen.core is
pure Python, so PyQt does not need to be installed to run this.
"""
import json
import os
import sys

HERE = os.path.dirname(os.path.abspath(__file__))
PYQT_ROOT = os.path.abspath(os.path.join(HERE, "..", ".."))
sys.path.insert(0, PYQT_ROOT)

from keygen import core
from keygen.core import Selection

RESULTS = os.path.join(HERE, "exe_results.json")


def main():
    with open(RESULTS, "r", encoding="utf-8") as fh:
        rows = json.load(fh)
    # ConvertTo-Json emits a bare object when there is exactly one result.
    if isinstance(rows, dict):
        rows = [rows]

    all_ok = True
    print("=" * 100)
    for row in rows:
        mods = row["modules"]
        checked = {code for code, st in mods.items() if st["checked"]}
        quantities = {code: st["qty"] for code, st in mods.items()}
        selection = Selection(
            customer_code=row["CCode"],
            install_code=row["SN"],
            company=row["REGSTR"],
            all_features=bool(row["ALL"]),
            all_quantity=row["ALLQTY"],
            checked=checked,
            quantities=quantities,
        )
        result = core.generate(selection)
        key_ok = result.serial == row["KEY"]
        pw_ok = result.password == row["PW"]
        ok = key_ok and pw_ok
        all_ok = all_ok and ok
        print(("[PASS]" if ok else "[FAIL]") + "  " + row["name"])
        print("   exe KEY : %s" % row["KEY"])
        print("   py  KEY : %s   %s" % (result.serial, "OK" if key_ok else "<<< MISMATCH"))
        print("   exe PW  : %s" % row["PW"])
        print("   py  PW  : %s   %s" % (result.password, "OK" if pw_ok else "<<< MISMATCH"))
        print("-" * 100)

    print("=" * 100)
    print("TOTAL: %d cases,  %s" % (len(rows), "ALL MATCH" if all_ok else "SOME MISMATCHED"))
    return 0 if all_ok else 1


if __name__ == "__main__":
    sys.exit(main())
