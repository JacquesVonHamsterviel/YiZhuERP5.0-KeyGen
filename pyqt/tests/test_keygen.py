"""Checks for the ported algorithm.

Where possible each helper is checked against an independent formulation of
what the VB code is doing (integer bit rotation, an integer bitmask) rather
than against a transcription of the same string manipulation.
"""

import hashlib
import os
import sys
import unittest

sys.path.insert(0, os.path.dirname(os.path.dirname(os.path.abspath(__file__))))

from keygen import core, vbcompat as vb
from keygen.core import Selection
from keygen.modules import FEATURE_BITS, FEATURE_TAGS, MODULES, MODULES_BY_CODE


class VbCompatTest(unittest.TestCase):
    def test_left_and_right_on_empty_string(self):
        self.assertEqual(vb.left("", 1), "")
        self.assertEqual(vb.right("", 1), "")

    def test_right_with_zero_count_is_empty(self):
        # Python's s[-0:] would return the whole string; VB returns "".
        self.assertEqual(vb.right("abcdef", 0), "")

    def test_mid_is_one_based(self):
        self.assertEqual(vb.mid("0123456789abcdef", 9, 8), "89abcdef")

    def test_val_reads_leading_number_only(self):
        self.assertEqual(vb.val("12ab"), 12.0)
        self.assertEqual(vb.val("ab"), 0.0)
        self.assertEqual(vb.val(""), 0.0)
        self.assertEqual(vb.val("-5"), -5.0)

    def test_val_ignores_embedded_blanks(self):
        self.assertEqual(vb.val(" 1 2 "), 12.0)

    def test_format_00_pads_and_keeps_wide_values(self):
        self.assertEqual(vb.format_00(0), "00")
        self.assertEqual(vb.format_00(5), "05")
        self.assertEqual(vb.format_00(99), "99")
        self.assertEqual(vb.format_00(123), "123")

    def test_format_00_rounds_half_away_from_zero(self):
        self.assertEqual(vb.format_00(2.5), "03")

    def test_default_encode_uses_gbk(self):
        self.assertEqual(vb.default_encode("中"), "中".encode("gbk"))


class BinaryHelpersTest(unittest.TestCase):
    def test_d_to_b_has_no_leading_zeros(self):
        self.assertEqual(core.d_to_b(0), "0")
        self.assertEqual(core.d_to_b(1), "1")
        self.assertEqual(core.d_to_b(255), "11111111")

    def test_b_to_h_left_pads_to_a_nibble(self):
        self.assertEqual(core.b_to_h("1"), "1")
        self.assertEqual(core.b_to_h("11111111"), "ff")

    def test_b_to_h_and_h_to_b_round_trip(self):
        for value in range(256):
            bits = format(value, "08b")
            self.assertEqual(core.h_to_b(core.b_to_h(bits)), bits)


class GetRolTest(unittest.TestCase):
    @staticmethod
    def _expected(text):
        """Each byte rotated right by its 1-based position mod 8."""
        out = ""
        for position, byte in enumerate(vb.default_encode(text), start=1):
            shift = position % 8
            rotated = ((byte >> shift) | (byte << (8 - shift))) & 0xFF
            out += format(rotated, "02X")
        return out

    def test_matches_integer_rotation(self):
        for text in ["", "A", "abcdefgh", "0123456789ABCDEF", "%%%@@@2", "中文公司"]:
            self.assertEqual(core.get_rol(text), self._expected(text))

    def test_eighth_byte_is_not_rotated(self):
        # Position 8 rotates by 0, so the byte passes through unchanged.
        self.assertEqual(core.get_rol("\x00" * 7 + "A")[-2:], "41")

    def test_two_hex_characters_per_ansi_byte(self):
        self.assertEqual(len(core.get_rol("abc")), 6)
        self.assertEqual(len(core.get_rol("中")), 4)


class FeatureFieldsTest(unittest.TestCase):
    @staticmethod
    def _selection(**kwargs):
        return Selection(customer_code="ABC123", install_code="SN-1",
                         company="测试公司", **kwargs)

    def test_all_features_shortcut(self):
        selection = self._selection(all_features=True, all_quantity="30")
        self.assertEqual(core.get_fn(selection), "ffffffff")
        self.assertEqual(core.get_fn_and_qty(selection), "")
        self.assertEqual(core.get_qty(selection), "30")

    def test_get_fn_matches_an_integer_bitmask(self):
        codes = {"BAS", "COP", "RMA"}
        selection = self._selection(checked=set(codes))
        mask = 0
        for code in codes:
            mask |= 1 << (FEATURE_BITS - 1 - MODULES_BY_CODE[code].index)
        self.assertEqual(core.get_fn(selection), format(mask, "08x"))

    def test_get_fn_single_module_bit_position(self):
        # BAS sits at index 21 of a 32-bit map, i.e. bit 2**10.
        selection = self._selection(checked={"BAS"})
        self.assertEqual(core.get_fn(selection), "00000400")

    def test_get_fn_with_nothing_selected(self):
        self.assertEqual(core.get_fn(self._selection()), "00000000")

    def test_get_fn_and_qty_is_emitted_in_index_order(self):
        selection = self._selection(
            checked={"BAS", "YSF", "COP"},
            quantities={"BAS": "5", "YSF": "10", "COP": "7"},
        )
        # YSF (2) then COP (15) then BAS (21).
        self.assertEqual(core.get_fn_and_qty(selection), "p10f07%05")

    def test_get_fn_and_qty_tags_come_from_the_feature_table(self):
        for module in MODULES:
            selection = self._selection(checked={module.code},
                                        quantities={module.code: "1"})
            self.assertEqual(core.get_fn_and_qty(selection),
                             FEATURE_TAGS[module.index] + "01")

    def test_get_qty_sums_every_module(self):
        selection = self._selection(
            checked={"BAS", "COP"},
            quantities={"BAS": "5", "COP": "7", "INV": "3"},
        )
        # The sum deliberately ignores which boxes are ticked, matching GetQty.
        self.assertEqual(core.get_qty(selection), "15")

    def test_get_qty_widens_past_two_digits(self):
        selection = self._selection(
            quantities={module.code: "99" for module in MODULES})
        self.assertEqual(core.get_qty(selection), "2178")


class GenerateTest(unittest.TestCase):
    def _selection(self, **kwargs):
        base = dict(customer_code="ABC123", install_code="INSTALL-01",
                    company="测试公司", checked={"BAS", "COP"},
                    quantities={"BAS": "5", "COP": "7"})
        base.update(kwargs)
        return Selection(**base)

    def test_empty_install_code_is_accepted(self):
        # Deviation from the original, which refused to run without it.
        result = core.generate(self._selection(install_code=""))
        self.assertEqual(len(result.password), 8)

    def test_empty_install_code_matches_a_blank_one(self):
        # The original already let "   " through and trimmed it away before
        # hashing, so an empty install code has to land on the same result.
        blank = core.generate(self._selection(install_code="   "))
        empty = core.generate(self._selection(install_code=""))
        self.assertEqual(empty.serial, blank.serial)
        self.assertEqual(empty.password, blank.password)

    def test_missing_customer_code_is_rejected(self):
        with self.assertRaises(core.KeygenError):
            core.generate(self._selection(customer_code=""))

    def test_serial_field_layout(self):
        fields = core.generate(self._selection()).serial.split("-")
        self.assertEqual(len(fields), 7)
        customer, quantity, features, features_and_qty, tag, company, checksum = fields
        self.assertEqual(customer, "ABC123")
        self.assertEqual(quantity, "12")
        self.assertEqual(features, core.get_fn(self._selection()))
        self.assertEqual(features_and_qty, "f07%05")
        self.assertEqual(tag, "@@@2")
        self.assertTrue(company.startswith("%%%"))
        self.assertEqual(len(checksum), 8)

    def test_all_features_serial_drops_the_per_module_field(self):
        selection = self._selection(all_features=True, all_quantity="30",
                                    checked=set())
        fields = core.generate(selection).serial.split("-")
        self.assertEqual(len(fields), 6)
        self.assertEqual(fields[2], "ffffffff")

    def test_checksum_is_the_first_half_of_the_md5(self):
        selection = self._selection()
        result = core.generate(selection)
        checksum = result.serial.rsplit("-", 1)[1]
        seed_fields = [selection.customer_code, core.get_qty(selection),
                       core.get_fn(selection), core.get_fn_and_qty(selection),
                       core.VERSION_TAG,
                       core.COMPANY_PREFIX + core.get_rol(selection.company)]
        seed = core.get_rol("".join(
            part[:1] if i % 2 else part[-1:] if part else ""
            for i, part in enumerate(seed_fields, start=1)))
        digest = hashlib.md5(
            vb.default_encode("".join(seed_fields) + seed)).hexdigest()
        self.assertEqual(checksum, digest[:8])

    def test_password_is_eight_characters(self):
        self.assertEqual(len(core.generate(self._selection()).password), 8)

    def test_password_depends_on_the_install_code(self):
        first = core.generate(self._selection(install_code="AAA"))
        second = core.generate(self._selection(install_code="BBB"))
        self.assertEqual(first.serial, second.serial)
        self.assertNotEqual(first.password, second.password)

    def test_install_code_is_trimmed(self):
        padded = core.generate(self._selection(install_code="  AAA  "))
        plain = core.generate(self._selection(install_code="AAA"))
        self.assertEqual(padded.password, plain.password)

    def test_regression_lock(self):
        # Not verified against the original binary (see README); this pins the
        # current output so refactors cannot silently change it.
        result = core.generate(Selection(
            customer_code="ABC123", install_code="INSTALL-01",
            company="测试公司", checked={"BAS", "COP"},
            quantities={"BAS": "5", "COP": "7"}))
        self.assertEqual(
            result.serial,
            "ABC123-12-00010400-f07%05-@@@2-%%%59B8594DCDAE97BE-571ae90f")
        self.assertEqual(result.password, "65cf3a6c")


if __name__ == "__main__":
    unittest.main()
