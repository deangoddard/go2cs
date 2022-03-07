// Code generated by running "go generate" in golang.org/x/text. DO NOT EDIT.

// Copyright 2016 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package idna -- go2cs converted at 2022 March 06 22:22:10 UTC
// import "golang.org/x/net/idna" ==> using idna = go.golang.org.x.net.idna_package
// Original source: C:\Users\ritchie\go\src\golang.org\x\net\idna\punycode.go
// This file implements the Punycode algorithm from RFC 3492.

using math = go.math_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;

namespace go.golang.org.x.net;

public static partial class idna_package {

    // These parameter values are specified in section 5.
    //
    // All computation is done with int32s, so that overflow behavior is identical
    // regardless of whether int is 32-bit or 64-bit.
private static readonly int base = 36;
private static readonly int damp = 700;
private static readonly int initialBias = 72;
private static readonly int initialN = 128;
private static readonly int skew = 38;
private static readonly int tmax = 26;
private static readonly int tmin = 1;


private static error punyError(@string s) {
    return error.As(addr(new labelError(s,"A3"))!)!;
}

// decode decodes a string as specified in section 6.2.
private static (@string, error) decode(@string encoded) {
    @string _p0 = default;
    error _p0 = default!;

    if (encoded == "") {
        return ("", error.As(null!)!);
    }
    nint pos = 1 + strings.LastIndex(encoded, "-");
    if (pos == 1) {
        return ("", error.As(punyError(encoded))!);
    }
    if (pos == len(encoded)) {
        return (encoded[..(int)len(encoded) - 1], error.As(null!)!);
    }
    var output = make_slice<int>(0, len(encoded));
    if (pos != 0) {
        foreach (var (_, r) in encoded[..(int)pos - 1]) {
            output = append(output, r);
        }
    }
    var i = int32(0);
    var n = initialN;
    var bias = initialBias;
    while (pos < len(encoded)) {
        var oldI = i;
        var w = int32(1);
        {
            var k = base;

            while (>>MARKER:FOREXPRESSION_LEVEL_2<<) {
                if (pos == len(encoded)) {
                    return ("", error.As(punyError(encoded))!);
                k += base;
                }

                var (digit, ok) = decodeDigit(encoded[pos]);
                if (!ok) {
                    return ("", error.As(punyError(encoded))!);
                }

                pos++;
                i += digit * w;
                if (i < 0) {
                    return ("", error.As(punyError(encoded))!);
                }

                var t = k - bias;
                if (t < tmin) {
                    t = tmin;
                }
                else if (t > tmax) {
                    t = tmax;
                }

                if (digit < t) {
                    break;
                }

                w *= base - t;
                if (w >= math.MaxInt32 / base) {
                    return ("", error.As(punyError(encoded))!);
                }

            }

        }
        var x = int32(len(output) + 1);
        bias = adapt(i - oldI, x, oldI == 0);
        n += i / x;
        i %= x;
        if (n > utf8.MaxRune || len(output) >= 1024) {
            return ("", error.As(punyError(encoded))!);
        }
        output = append(output, 0);
        copy(output[(int)i + 1..], output[(int)i..]);
        output[i] = n;
        i++;

    }
    return (string(output), error.As(null!)!);

}

// encode encodes a string as specified in section 6.3 and prepends prefix to
// the result.
//
// The "while h < length(input)" line in the specification becomes "for
// remaining != 0" in the Go code, because len(s) in Go is in bytes, not runes.
private static (@string, error) encode(@string prefix, @string s) {
    @string _p0 = default;
    error _p0 = default!;

    var output = make_slice<byte>(len(prefix), len(prefix) + 1 + 2 * len(s));
    copy(output, prefix);
    var delta = int32(0);
    var n = initialN;
    var bias = initialBias;
    var b = int32(0);
    var remaining = int32(0);
    {
        var r__prev1 = r;

        foreach (var (_, __r) in s) {
            r = __r;
            if (r < 0x80) {
                b++;
                output = append(output, byte(r));
            }
            else
 {
                remaining++;
            }

        }
        r = r__prev1;
    }

    var h = b;
    if (b > 0) {
        output = append(output, '-');
    }
    while (remaining != 0) {
        var m = int32(0x7fffffff);
        {
            var r__prev2 = r;

            foreach (var (_, __r) in s) {
                r = __r;
                if (m > r && r >= n) {
                    m = r;
                }
            }

            r = r__prev2;
        }

        delta += (m - n) * (h + 1);
        if (delta < 0) {
            return ("", error.As(punyError(s))!);
        }
        n = m;
        {
            var r__prev2 = r;

            foreach (var (_, __r) in s) {
                r = __r;
                if (r < n) {
                    delta++;
                    if (delta < 0) {
                        return ("", error.As(punyError(s))!);
                    }
                    continue;
                }
                if (r > n) {
                    continue;
                }
                var q = delta;
                {
                    var k = base;

                    while (>>MARKER:FOREXPRESSION_LEVEL_3<<) {
                        var t = k - bias;
                        if (t < tmin) {
                            t = tmin;
                        k += base;
                        }
                        else if (t > tmax) {
                            t = tmax;
                        }

                        if (q < t) {
                            break;
                        }

                        output = append(output, encodeDigit(t + (q - t) % (base - t)));
                        q = (q - t) / (base - t);

                    }

                }
                output = append(output, encodeDigit(q));
                bias = adapt(delta, h + 1, h == b);
                delta = 0;
                h++;
                remaining--;

            }

            r = r__prev2;
        }

        delta++;
        n++;

    }
    return (string(output), error.As(null!)!);

}

private static (int, bool) decodeDigit(byte x) {
    int digit = default;
    bool ok = default;


    if ('0' <= x && x <= '9') 
        return (int32(x - ('0' - 26)), true);
    else if ('A' <= x && x <= 'Z') 
        return (int32(x - 'A'), true);
    else if ('a' <= x && x <= 'z') 
        return (int32(x - 'a'), true);
        return (0, false);

}

private static byte encodeDigit(int digit) => func((_, panic, _) => {

    if (0 <= digit && digit < 26) 
        return byte(digit + 'a');
    else if (26 <= digit && digit < 36) 
        return byte(digit + ('0' - 26));
        panic("idna: internal error in punycode encoding");

});

// adapt is the bias adaptation function specified in section 6.1.
private static int adapt(int delta, int numPoints, bool firstTime) {
    if (firstTime) {
        delta /= damp;
    }
    else
 {
        delta /= 2;
    }
    delta += delta / numPoints;
    var k = int32(0);
    while (delta > ((base - tmin) * tmax) / 2) {
        delta /= base - tmin;
        k += base;
    }
    return k + (base - tmin + 1) * delta / (delta + skew);

}

} // end idna_package
