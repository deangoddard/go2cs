// Copyright 2017 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package runtime -- go2cs converted at 2020 August 29 08:16:56 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\float.go
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go
{
    public static unsafe partial class runtime_package
    {
        private static var inf = float64frombits(0x7FF0000000000000UL);

        // isNaN reports whether f is an IEEE 754 ``not-a-number'' value.
        private static bool isNaN(double f)
        { 
            // IEEE 754 says that only NaNs satisfy f != f.
            return f != f;
        }

        // isFinite reports whether f is neither NaN nor an infinity.
        private static bool isFinite(double f)
        {
            return !isNaN(f - f);
        }

        // isInf reports whether f is an infinity.
        private static bool isInf(double f)
        {
            return !isNaN(f) && !isFinite(f);
        }

        // Abs returns the absolute value of x.
        //
        // Special cases are:
        //    Abs(±Inf) = +Inf
        //    Abs(NaN) = NaN
        private static double abs(double x)
        {
            const long sign = 1L << (int)(63L);

            return float64frombits(float64bits(x) & ~sign);
        }

        // copysign returns a value with the magnitude
        // of x and the sign of y.
        private static double copysign(double x, double y)
        {
            const long sign = 1L << (int)(63L);

            return float64frombits(float64bits(x) & ~sign | float64bits(y) & sign);
        }

        // Float64bits returns the IEEE 754 binary representation of f.
        private static ulong float64bits(double f)
        {
            return @unsafe.Pointer(ref f).Value;
        }

        // Float64frombits returns the floating point number corresponding
        // the IEEE 754 binary representation b.
        private static double float64frombits(ulong b)
        {
            return @unsafe.Pointer(ref b).Value;
        }
    }
}
