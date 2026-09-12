"""Serial number / verification password algorithm.

A direct port of ``Form1.Button1_Click`` and its helpers in
``TPA/Form1.cs``.  Nothing here touches Qt, so the algorithm can be exercised
from tests or a script without a display.
"""

import hashlib
from dataclasses import dataclass, field

from . import vbcompat as vb
from .modules import FEATURE_BITS, FEATURE_TAGS, MODULES

# Fixed marker the original splices into the serial as the fourth-from-last
# field; it identifies the 5.0 key format.
VERSION_TAG = "@@@2"
COMPANY_PREFIX = "%%%"
ALL_FEATURES_FN = "ffffffff"


class KeygenError(ValueError):
    """Raised when a required input is missing."""


@dataclass
class Selection:
    """Everything the form collects, in raw text form."""

    customer_code: str = ""       # CCode
    install_code: str = ""        # SN
    company: str = ""             # REGSTR
    all_features: bool = False    # ALL check box
    all_quantity: str = ""        # ALLQTY
    checked: set = field(default_factory=set)        # module codes
    quantities: dict = field(default_factory=dict)   # module code -> raw text


@dataclass
class Result:
    serial: str      # KEY
    password: str    # PW


def d_to_b(value):
    """``d_to_b`` - binary without leading zeros; 0 maps to "0"."""
    bits = ""
    while True:
        bits = str(value % 2) + bits
        value //= 2
        if value == 0:
            return bits


def b_to_h(binary):
    """``b_to_h`` - left-pad to a whole number of nibbles, emit lowercase hex."""
    remainder = len(binary) % 4
    if remainder != 0:
        binary = vb.str_dup(4 - remainder, "0") + binary
    digits = ""
    for start in range(0, len(binary), 4):
        nibble = binary[start:start + 4]
        try:
            digits += "0123456789abcdef"[int(nibble, 2)]
        except ValueError:
            # The original's if/else chain simply appends nothing for a group
            # that is not four binary digits.
            pass
    return digits


def h_to_b(hex_digits):
    """``h_to_b`` - the inverse of :func:`b_to_h`, four bits per digit."""
    bits = ""
    for digit in hex_digits.lower():
        if digit in "0123456789abcdef":
            bits += format(int(digit, 16), "04b")
    return bits


def get_rol(text):
    """``GetROL`` - rotate each byte right by its own 1-based position mod 8.

    The result is two uppercase hex characters per *byte* of the ANSI encoding,
    so a Chinese character contributes four.
    """
    out = ""
    data = vb.default_encode(text)
    for position, byte in enumerate(data, start=1):
        bits = d_to_b(byte)
        bits = vb.str_dup(8 - len(bits), "0") + bits
        shift = position % 8
        bits = vb.right(bits, shift) + vb.left(bits, 8 - shift)
        out += b_to_h(bits).upper()
    return out


def get_qty(selection):
    """``GetQty`` - the licensed user count, zero-padded to at least 2 digits."""
    if selection.all_features:
        return vb.format_00(vb.val(selection.all_quantity))
    total = sum(vb.val(selection.quantities.get(module.code, "")) for module in MODULES)
    return vb.format_00(total)


def get_fn(selection):
    """``GetFn`` - the selected modules as an 8-digit hex bitmap."""
    if selection.all_features:
        return ALL_FEATURES_FN
    bits = ["0"] * FEATURE_BITS
    for module in MODULES:
        if module.code in selection.checked:
            bits[module.index] = "1"
    return b_to_h("".join(bits))


def get_fn_and_qty(selection):
    """``GetFnAndQty`` - per-module tag plus that module's user count."""
    if selection.all_features:
        return ""
    out = ""
    for module in MODULES:
        if module.code in selection.checked:
            quantity = vb.val(selection.quantities.get(module.code, ""))
            out += FEATURE_TAGS[module.index] + vb.format_00(quantity)
    return out


def md5_hash(text):
    """``getMd5Hash`` - lowercase hex MD5 over the ANSI-encoded string."""
    return hashlib.md5(vb.default_encode(text)).hexdigest()


def _interleave(parts):
    """Take the first character of odd parts and the last of even parts.

    ``Button1_Click`` builds its pre-hash seed with a 1-based loop, so the
    first element is an "odd" position.
    """
    seed = ""
    for position, part in enumerate(parts, start=1):
        seed += vb.left(part, 1) if position % 2 != 0 else vb.right(part, 1)
    return seed


def generate(selection):
    """Port of ``Button1_Click``. Returns the serial and verification password.

    Unlike the original, an empty install code is allowed.  The original only
    rejected the untrimmed empty string, so a blank-only install code already
    got through and was trimmed to "" before hashing; an empty one now lands on
    exactly that result.
    """
    if not selection.customer_code:
        raise KeygenError("请输入客户代号")

    customer = selection.customer_code
    quantity = get_qty(selection)
    features = get_fn(selection)
    features_and_qty = get_fn_and_qty(selection)
    company = COMPANY_PREFIX + get_rol(selection.company)
    install = selection.install_code.strip()

    # With every feature licensed the per-module field is dropped from the
    # serial entirely; it stays in the hash input, but it is "" by then.
    if selection.all_features:
        serial_fields = [customer, quantity, features, VERSION_TAG, company]
    else:
        serial_fields = [customer, quantity, features, features_and_qty, VERSION_TAG, company]

    seed = get_rol(_interleave(serial_fields))
    digest = md5_hash(customer + quantity + features + features_and_qty
                      + VERSION_TAG + company + seed)
    checksum = vb.left(digest, 8)

    serial = "-".join(serial_fields + [checksum])

    password_fields = serial_fields + [checksum, install]
    seed = get_rol(_interleave(password_fields))
    digest = md5_hash(customer + quantity + features + features_and_qty
                      + VERSION_TAG + company + checksum + install + seed)
    password = vb.mid(digest, 9, 8)

    return Result(serial=serial, password=password)
