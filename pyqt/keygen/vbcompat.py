"""Re-implementations of the Microsoft.VisualBasic runtime helpers.

The C# sources under ``TPA/`` were recovered with dnSpy from a VB.NET binary,
so they still call ``Strings.Left/Right/Mid``, ``Strings.Format`` and
``Conversion.Val``.  Those differ from the obvious Python equivalents in ways
the generated serial actually depends on (1-based indexing, ``Val`` skipping
embedded blanks, ``Format`` padding to a minimum width), so they are reproduced
here rather than approximated at the call sites.
"""

import re
from decimal import Decimal, ROUND_HALF_UP

# Encoding.Default on .NET Framework is the system ANSI code page.  The
# original targets Chinese Windows, where that is code page 936 (GBK).
ANSI_CODEPAGE = "gbk"


def default_encode(text):
    """``Encoding.Default.GetBytes``.

    Characters the code page cannot represent become ``?``, which is what
    .NET's default replacement fallback does.
    """
    return text.encode(ANSI_CODEPAGE, errors="replace")


def left(text, count):
    """``Strings.Left`` - a Nothing/None string yields ""."""
    if not text:
        return ""
    return text[:count]


def right(text, count):
    """``Strings.Right`` - note that count 0 yields "", not the whole string."""
    if not text or count <= 0:
        return ""
    return text[-count:]


def mid(text, start, length=None):
    """``Strings.Mid`` with a 1-based start position."""
    if not text:
        return ""
    if length is None:
        return text[start - 1:]
    return text[start - 1:start - 1 + length]


def str_dup(count, char):
    """``Strings.StrDup``."""
    return char * count if count > 0 else ""


# Val() reads the longest leading run that looks like a number and returns 0
# when there is none.
_LEADING_NUMBER = re.compile(r"[+-]?(?:\d+\.?\d*|\.\d+)(?:[eE][+-]?\d+)?")


def val(text):
    """``Conversion.Val`` - blanks, tabs and line feeds are ignored outright."""
    if not text:
        return 0.0
    stripped = re.sub(r"[ \t\n\r\f\v]", "", text)
    match = _LEADING_NUMBER.match(stripped)
    if match is None:
        return 0.0
    try:
        return float(match.group(0))
    except ValueError:
        return 0.0


def format_00(number):
    """``Strings.Format(number, "00")`` - round to an integer, pad to 2 digits.

    Values above 99 keep all their digits, which is what makes the summed user
    count in ``get_qty`` widen to three characters.
    """
    rounded = int(Decimal(repr(float(number))).quantize(Decimal(1), rounding=ROUND_HALF_UP))
    sign = "-" if rounded < 0 else ""
    return "{}{:02d}".format(sign, abs(rounded))
