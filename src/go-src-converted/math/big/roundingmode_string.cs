// generated by stringer -type=RoundingMode; DO NOT EDIT

// package big -- go2cs converted at 2020 August 29 08:29:33 UTC
// import "math/big" ==> using big = go.math.big_package
// Original source: C:\Go\src\math\big\roundingmode_string.go
using fmt = go.fmt_package;
using static go.builtin;

namespace go {
namespace math
{
    public static partial class big_package
    {
        private static readonly @string _RoundingMode_name = "ToNearestEvenToNearestAwayToZeroAwayFromZeroToNegativeInfToPositiveInf";



        private static array<byte> _RoundingMode_index = new array<byte>(new byte[] { 0, 13, 26, 32, 44, 57, 70 });

        public static @string String(this RoundingMode i)
        {
            if (i + 1L >= RoundingMode(len(_RoundingMode_index)))
            {
                return fmt.Sprintf("RoundingMode(%d)", i);
            }
            return _RoundingMode_name[_RoundingMode_index[i].._RoundingMode_index[i + 1L]];
        }
    }
}}
