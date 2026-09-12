/*
 * 易助 5.0 KeyGen - HTML/JS port of TPA/Form1.cs (Button1_Click and helpers).
 *
 * Ported from the PyQt version's keygen/core.py, which has been cross-checked
 * byte-for-byte against the original exe (see pyqt/tools/crosscheck).  Pure
 * logic: no DOM access here.  This file is intentionally ASCII-only so it loads
 * correctly regardless of how the browser guesses its charset; the Chinese UI
 * labels live in index.html.
 *
 * Exposes a global `Keygen` (and CommonJS export when available).
 */
(function (root) {
  "use strict";

  // ---- the 22 modules, in ascending feature-bit index order ---------------
  // GetFn flips slot `index` of a 32-char bit string; GetFnAndQty emits
  // FEATURE_TAGS[index] + the module's user count, in this same order.
  var FEATURE_TAGS = "mjpdruebwynkatqf~!@#$%^&*(){}=+?";
  var FEATURE_BITS = 32;

  var MODULES = [
    { code: "YSF", index: 2 },  { code: "PJM", index: 3 },
    { code: "KJS", index: 4 },  { code: "RGS", index: 5 },
    { code: "SGM", index: 6 },  { code: "CRM", index: 7 },
    { code: "GZS", index: 8 },  { code: "ZCS", index: 9 },
    { code: "SXM", index: 10 }, { code: "SCM", index: 11 },
    { code: "GYS", index: 12 }, { code: "JCA", index: 13 },
    { code: "CWB", index: 14 }, { code: "COP", index: 15 },
    { code: "PUR", index: 16 }, { code: "INV", index: 17 },
    { code: "WLB", index: 18 }, { code: "FIB", index: 19 },
    { code: "SYS", index: 20 }, { code: "BAS", index: 21 },
    { code: "QMS", index: 22 }, { code: "RMA", index: 23 }
  ];

  // Reading order of the feature group box (Form1.Designer.cs), "ALL" is the
  // "所有功能" check box, not a module.
  var ALL_CODE = "ALL";
  var COLUMNS = [
    ["BAS", "FIB", "JCA", "QMS", "SGM", "YSF"],
    ["COP", "GYS", "KJS", "RGS", "SXM", "ZCS"],
    ["CRM", "GZS", "PJM", "RMA", "SYS", ALL_CODE],
    ["CWB", "INV", "PUR", "SCM", "WLB"]
  ];

  var VERSION_TAG = "@@@2";
  var COMPANY_PREFIX = "%%%";
  var ALL_FEATURES_FN = "ffffffff";

  // ---- GBK (code page 936) encoding, i.e. .NET Encoding.Default -----------
  // The browser ships a GBK *decoder* but no encoder, so build a char->bytes
  // table once by decoding every valid GBK byte sequence.
  var gbkMap = null;
  function buildGbkMap() {
    if (typeof TextDecoder === "undefined") {
      throw new Error("TextDecoder is unavailable; cannot GBK-encode.");
    }
    var dec;
    try {
      dec = new TextDecoder("gbk", { fatal: false });
    } catch (e) {
      throw new Error("This browser has no GBK decoder; cannot reproduce the algorithm.");
    }
    var map = Object.create(null);
    var i, ch;
    // single bytes (ASCII + a few singletons)
    for (i = 0; i <= 0xff; i++) {
      ch = dec.decode(new Uint8Array([i]));
      if (ch.length === 1 && ch !== "�" && map[ch] === undefined) {
        map[ch] = [i];
      }
    }
    // double bytes: lead 0x81-0xFE, trail 0x40-0xFE (excluding 0x7F)
    var hi, lo;
    for (hi = 0x81; hi <= 0xfe; hi++) {
      for (lo = 0x40; lo <= 0xfe; lo++) {
        if (lo === 0x7f) continue;
        ch = dec.decode(new Uint8Array([hi, lo]));
        if (ch.length === 1 && ch !== "�" && map[ch] === undefined) {
          map[ch] = [hi, lo];
        }
      }
    }
    return map;
  }

  function defaultEncode(text) {
    if (gbkMap === null) gbkMap = buildGbkMap();
    var out = [];
    for (var i = 0; i < text.length; i++) {
      var ch = text.charAt(i);
      var bytes = gbkMap[ch];
      if (bytes !== undefined) {
        for (var j = 0; j < bytes.length; j++) out.push(bytes[j]);
      } else {
        var code = text.charCodeAt(i);
        // .NET's default replacement fallback emits '?' for unrepresentable chars.
        out.push(code < 128 ? code : 0x3f);
      }
    }
    return out;
  }

  // ---- Microsoft.VisualBasic runtime helpers -----------------------------
  function left(text, count) {
    if (!text) return "";
    return text.substring(0, count);
  }
  function right(text, count) {
    if (!text || count <= 0) return "";
    return text.substring(text.length - count);
  }
  function mid(text, start, length) {
    if (!text) return "";
    if (length === undefined) return text.substring(start - 1);
    return text.substring(start - 1, start - 1 + length);
  }
  function strDup(count, ch) {
    return count > 0 ? new Array(count + 1).join(ch) : "";
  }
  var LEADING_NUMBER = /^[+-]?(?:\d+\.?\d*|\.\d+)(?:[eE][+-]?\d+)?/;
  function val(text) {
    if (!text) return 0;
    var stripped = String(text).replace(/[ \t\n\r\f\v]/g, "");
    var m = LEADING_NUMBER.exec(stripped);
    if (m === null) return 0;
    var n = parseFloat(m[0]);
    return isNaN(n) ? 0 : n;
  }
  function format00(number) {
    // Strings.Format(n, "00"): round half away from zero, pad to >= 2 digits.
    var sign = number < 0 ? "-" : "";
    var rounded = Math.round(Math.abs(number)); // Math.round on |n| == half away from zero
    var s = String(rounded);
    if (s.length < 2) s = strDup(2 - s.length, "0") + s;
    return sign + s;
  }

  // ---- binary/hex helpers -------------------------------------------------
  function dToB(value) {
    var bits = "";
    while (true) {
      bits = String(value % 2) + bits;
      value = Math.floor(value / 2);
      if (value === 0) return bits;
    }
  }
  function bToH(binary) {
    var remainder = binary.length % 4;
    if (remainder !== 0) binary = strDup(4 - remainder, "0") + binary;
    var digits = "";
    for (var start = 0; start < binary.length; start += 4) {
      var nibble = binary.substring(start, start + 4);
      if (/^[01]{4}$/.test(nibble)) {
        digits += "0123456789abcdef".charAt(parseInt(nibble, 2));
      }
    }
    return digits;
  }

  // ---- GetROL -------------------------------------------------------------
  function getRol(text) {
    var out = "";
    var data = defaultEncode(text);
    for (var i = 0; i < data.length; i++) {
      var position = i + 1; // 1-based
      var bits = dToB(data[i]);
      bits = strDup(8 - bits.length, "0") + bits;
      var shift = position % 8;
      bits = right(bits, shift) + left(bits, 8 - shift);
      out += bToH(bits).toUpperCase();
    }
    return out;
  }

  // ---- MD5 over a byte array (== getMd5Hash: MD5 of Encoding.Default bytes) --
  function md5Bytes(bytes) {
    function safeAdd(x, y) {
      var lsw = (x & 0xffff) + (y & 0xffff);
      var msw = (x >> 16) + (y >> 16) + (lsw >> 16);
      return (msw << 16) | (lsw & 0xffff);
    }
    function rol(num, cnt) { return (num << cnt) | (num >>> (32 - cnt)); }
    function cmn(q, a, b, x, s, t) { return safeAdd(rol(safeAdd(safeAdd(a, q), safeAdd(x, t)), s), b); }
    function ff(a, b, c, d, x, s, t) { return cmn((b & c) | (~b & d), a, b, x, s, t); }
    function gg(a, b, c, d, x, s, t) { return cmn((b & d) | (c & ~d), a, b, x, s, t); }
    function hh(a, b, c, d, x, s, t) { return cmn(b ^ c ^ d, a, b, x, s, t); }
    function ii(a, b, c, d, x, s, t) { return cmn(c ^ (b | ~d), a, b, x, s, t); }

    // bytes -> little-endian 32-bit words
    var x = [];
    var i;
    for (i = 0; i < bytes.length * 8; i += 8) {
      x[i >> 5] |= (bytes[i / 8] & 0xff) << (i % 32);
    }
    var len = bytes.length * 8;
    x[len >> 5] |= 0x80 << (len % 32);
    x[(((len + 64) >>> 9) << 4) + 14] = len;
    for (i = 0; i < x.length; i++) if (x[i] === undefined) x[i] = 0;

    var a = 1732584193, b = -271733879, c = -1732584194, d = 271733878;
    for (i = 0; i < x.length; i += 16) {
      var oa = a, ob = b, oc = c, od = d;
      a = ff(a, b, c, d, x[i], 7, -680876936);
      d = ff(d, a, b, c, x[i + 1], 12, -389564586);
      c = ff(c, d, a, b, x[i + 2], 17, 606105819);
      b = ff(b, c, d, a, x[i + 3], 22, -1044525330);
      a = ff(a, b, c, d, x[i + 4], 7, -176418897);
      d = ff(d, a, b, c, x[i + 5], 12, 1200080426);
      c = ff(c, d, a, b, x[i + 6], 17, -1473231341);
      b = ff(b, c, d, a, x[i + 7], 22, -45705983);
      a = ff(a, b, c, d, x[i + 8], 7, 1770035416);
      d = ff(d, a, b, c, x[i + 9], 12, -1958414417);
      c = ff(c, d, a, b, x[i + 10], 17, -42063);
      b = ff(b, c, d, a, x[i + 11], 22, -1990404162);
      a = ff(a, b, c, d, x[i + 12], 7, 1804603682);
      d = ff(d, a, b, c, x[i + 13], 12, -40341101);
      c = ff(c, d, a, b, x[i + 14], 17, -1502002290);
      b = ff(b, c, d, a, x[i + 15], 22, 1236535329);

      a = gg(a, b, c, d, x[i + 1], 5, -165796510);
      d = gg(d, a, b, c, x[i + 6], 9, -1069501632);
      c = gg(c, d, a, b, x[i + 11], 14, 643717713);
      b = gg(b, c, d, a, x[i], 20, -373897302);
      a = gg(a, b, c, d, x[i + 5], 5, -701558691);
      d = gg(d, a, b, c, x[i + 10], 9, 38016083);
      c = gg(c, d, a, b, x[i + 15], 14, -660478335);
      b = gg(b, c, d, a, x[i + 4], 20, -405537848);
      a = gg(a, b, c, d, x[i + 9], 5, 568446438);
      d = gg(d, a, b, c, x[i + 14], 9, -1019803690);
      c = gg(c, d, a, b, x[i + 3], 14, -187363961);
      b = gg(b, c, d, a, x[i + 8], 20, 1163531501);
      a = gg(a, b, c, d, x[i + 13], 5, -1444681467);
      d = gg(d, a, b, c, x[i + 2], 9, -51403784);
      c = gg(c, d, a, b, x[i + 7], 14, 1735328473);
      b = gg(b, c, d, a, x[i + 12], 20, -1926607734);

      a = hh(a, b, c, d, x[i + 5], 4, -378558);
      d = hh(d, a, b, c, x[i + 8], 11, -2022574463);
      c = hh(c, d, a, b, x[i + 11], 16, 1839030562);
      b = hh(b, c, d, a, x[i + 14], 23, -35309556);
      a = hh(a, b, c, d, x[i + 1], 4, -1530992060);
      d = hh(d, a, b, c, x[i + 4], 11, 1272893353);
      c = hh(c, d, a, b, x[i + 7], 16, -155497632);
      b = hh(b, c, d, a, x[i + 10], 23, -1094730640);
      a = hh(a, b, c, d, x[i + 13], 4, 681279174);
      d = hh(d, a, b, c, x[i], 11, -358537222);
      c = hh(c, d, a, b, x[i + 3], 16, -722521979);
      b = hh(b, c, d, a, x[i + 6], 23, 76029189);
      a = hh(a, b, c, d, x[i + 9], 4, -640364487);
      d = hh(d, a, b, c, x[i + 12], 11, -421815835);
      c = hh(c, d, a, b, x[i + 15], 16, 530742520);
      b = hh(b, c, d, a, x[i + 2], 23, -995338651);

      a = ii(a, b, c, d, x[i], 6, -198630844);
      d = ii(d, a, b, c, x[i + 7], 10, 1126891415);
      c = ii(c, d, a, b, x[i + 14], 15, -1416354905);
      b = ii(b, c, d, a, x[i + 5], 21, -57434055);
      a = ii(a, b, c, d, x[i + 12], 6, 1700485571);
      d = ii(d, a, b, c, x[i + 3], 10, -1894986606);
      c = ii(c, d, a, b, x[i + 10], 15, -1051523);
      b = ii(b, c, d, a, x[i + 1], 21, -2054922799);
      a = ii(a, b, c, d, x[i + 8], 6, 1873313359);
      d = ii(d, a, b, c, x[i + 15], 10, -30611744);
      c = ii(c, d, a, b, x[i + 6], 15, -1560198380);
      b = ii(b, c, d, a, x[i + 13], 21, 1309151649);
      a = ii(a, b, c, d, x[i + 4], 6, -145523070);
      d = ii(d, a, b, c, x[i + 11], 10, -1120210379);
      c = ii(c, d, a, b, x[i + 2], 15, 718787259);
      b = ii(b, c, d, a, x[i + 9], 21, -343485551);

      a = safeAdd(a, oa); b = safeAdd(b, ob); c = safeAdd(c, oc); d = safeAdd(d, od);
    }

    var words = [a, b, c, d];
    var hex = "0123456789abcdef";
    var str = "";
    for (i = 0; i < words.length * 4; i++) {
      str += hex.charAt((words[i >> 2] >> ((i % 4) * 8 + 4)) & 0xf) +
             hex.charAt((words[i >> 2] >> ((i % 4) * 8)) & 0xf);
    }
    return str;
  }
  function md5Hash(text) { return md5Bytes(defaultEncode(text)); }

  // ---- feature fields -----------------------------------------------------
  function asSet(checked) {
    var set = Object.create(null);
    if (!checked) return set;
    if (typeof checked.forEach === "function" && !Array.isArray(checked)) {
      checked.forEach(function (c) { set[c] = true; }); // a Set
    } else {
      for (var i = 0; i < checked.length; i++) set[checked[i]] = true;
    }
    return set;
  }
  function getQty(sel) {
    if (sel.allFeatures) return format00(val(sel.allQuantity));
    var total = 0;
    for (var i = 0; i < MODULES.length; i++) {
      total += val(sel.quantities ? sel.quantities[MODULES[i].code] : "");
    }
    return format00(total);
  }
  function getFn(sel) {
    if (sel.allFeatures) return ALL_FEATURES_FN;
    var checked = asSet(sel.checked);
    var bits = new Array(FEATURE_BITS);
    for (var i = 0; i < FEATURE_BITS; i++) bits[i] = "0";
    for (var m = 0; m < MODULES.length; m++) {
      if (checked[MODULES[m].code]) bits[MODULES[m].index] = "1";
    }
    return bToH(bits.join(""));
  }
  function getFnAndQty(sel) {
    if (sel.allFeatures) return "";
    var checked = asSet(sel.checked);
    var out = "";
    for (var m = 0; m < MODULES.length; m++) {
      var mod = MODULES[m];
      if (checked[mod.code]) {
        var q = val(sel.quantities ? sel.quantities[mod.code] : "");
        out += FEATURE_TAGS.charAt(mod.index) + format00(q);
      }
    }
    return out;
  }

  function interleave(parts) {
    var seed = "";
    for (var i = 0; i < parts.length; i++) {
      var position = i + 1; // 1-based
      seed += (position % 2 !== 0) ? left(parts[i], 1) : right(parts[i], 1);
    }
    return seed;
  }

  // ---- generate (port of Button1_Click) ----------------------------------
  function generate(sel) {
    if (!sel.customerCode) {
      var err = new Error("请输入客户代号");
      err.name = "KeygenError";
      throw err;
    }
    var customer = sel.customerCode;
    var quantity = getQty(sel);
    var features = getFn(sel);
    var featuresAndQty = getFnAndQty(sel);
    var company = COMPANY_PREFIX + getRol(sel.company || "");
    var install = (sel.installCode || "").replace(/^\s+|\s+$/g, ""); // .Trim()

    var serialFields = sel.allFeatures
      ? [customer, quantity, features, VERSION_TAG, company]
      : [customer, quantity, features, featuresAndQty, VERSION_TAG, company];

    var seed = getRol(interleave(serialFields));
    var digest = md5Hash(customer + quantity + features + featuresAndQty +
                         VERSION_TAG + company + seed);
    var checksum = left(digest, 8);

    var serial = serialFields.concat([checksum]).join("-");

    var passwordFields = serialFields.concat([checksum, install]);
    seed = getRol(interleave(passwordFields));
    digest = md5Hash(customer + quantity + features + featuresAndQty +
                     VERSION_TAG + company + checksum + install + seed);
    var password = mid(digest, 9, 8);

    return { serial: serial, password: password };
  }

  var Keygen = {
    MODULES: MODULES,
    COLUMNS: COLUMNS,
    ALL_CODE: ALL_CODE,
    FEATURE_TAGS: FEATURE_TAGS,
    VERSION_TAG: VERSION_TAG,
    // helpers exposed for testing / cross-checking
    defaultEncode: defaultEncode,
    left: left, right: right, mid: mid, val: val, format00: format00,
    dToB: dToB, bToH: bToH, getRol: getRol, md5Hash: md5Hash,
    getQty: getQty, getFn: getFn, getFnAndQty: getFnAndQty,
    generate: generate
  };

  root.Keygen = Keygen;
  if (typeof module !== "undefined" && module.exports) module.exports = Keygen;
})(typeof window !== "undefined" ? window : this);
