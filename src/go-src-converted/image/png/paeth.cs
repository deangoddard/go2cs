// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package png -- go2cs converted at 2022 March 06 23:36:15 UTC
// import "image/png" ==> using png = go.image.png_package
// Original source: C:\Program Files\Go\src\image\png\paeth.go


namespace go.image;

public static partial class png_package {

    // intSize is either 32 or 64.
private static readonly nint intSize = 32 << (int)((~uint(0) >> 63));



private static nint abs(nint x) { 
    // m := -1 if x < 0. m := 0 otherwise.
    var m = x >> (int)((intSize - 1)); 

    // In two's complement representation, the negative number
    // of any number (except the smallest one) can be computed
    // by flipping all the bits and add 1. This is faster than
    // code with a branch.
    // See Hacker's Delight, section 2-4.
    return (x ^ m) - m;

}

// paeth implements the Paeth filter function, as per the PNG specification.
private static byte paeth(byte a, byte b, byte c) { 
    // This is an optimized version of the sample code in the PNG spec.
    // For example, the sample code starts with:
    //    p := int(a) + int(b) - int(c)
    //    pa := abs(p - int(a))
    // but the optimized form uses fewer arithmetic operations:
    //    pa := int(b) - int(c)
    //    pa = abs(pa)
    var pc = int(c);
    var pa = int(b) - pc;
    var pb = int(a) - pc;
    pc = abs(pa + pb);
    pa = abs(pa);
    pb = abs(pb);
    if (pa <= pb && pa <= pc) {
        return a;
    }
    else if (pb <= pc) {
        return b;
    }
    return c;

}

// filterPaeth applies the Paeth filter to the cdat slice.
// cdat is the current row's data, pdat is the previous row's data.
private static void filterPaeth(slice<byte> cdat, slice<byte> pdat, nint bytesPerPixel) {
    nint a = default;    nint b = default;    nint c = default;    nint pa = default;    nint pb = default;    nint pc = default;

    for (nint i = 0; i < bytesPerPixel; i++) {
        (a, c) = (0, 0);        {
            var j = i;

            while (j < len(cdat)) {
                b = int(pdat[j]);
                pa = b - c;
                pb = a - c;
                pc = abs(pa + pb);
                pa = abs(pa);
                pb = abs(pb);
                if (pa <= pb && pa <= pc) { 
                    // No-op.
                j += bytesPerPixel;
                }
                else if (pb <= pc) {
                    a = b;
                }
                else
 {
                    a = c;
                }

                a += int(cdat[j]);
                a &= 0xff;
                cdat[j] = uint8(a);
                c = b;

            }

        }

    }

}

} // end png_package
