// Code generated by "stringer -type=RoundingMode"; DO NOT EDIT.

// package big -- go2cs converted at 2022 March 13 05:32:19 UTC
// import "math/big" ==> using big = go.math.big_package
// Original source: C:\Program Files\Go\src\math\big\roundingmode_string.go
namespace go.math;

using strconv = strconv_package;

public static partial class big_package {

private static readonly @string _RoundingMode_name = "ToNearestEvenToNearestAwayToZeroAwayFromZeroToNegativeInfToPositiveInf";



private static array<byte> _RoundingMode_index = new array<byte>(new byte[] { 0, 13, 26, 32, 44, 57, 70 });

public static @string String(this RoundingMode i) {
    if (i >= RoundingMode(len(_RoundingMode_index) - 1)) {
        return "RoundingMode(" + strconv.FormatInt(int64(i), 10) + ")";
    }
    return _RoundingMode_name[(int)_RoundingMode_index[i]..(int)_RoundingMode_index[i + 1]];
}

} // end big_package
