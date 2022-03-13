// Code generated by "stringer -type AlgKind -trimprefix A alg.go"; DO NOT EDIT.

// package types -- go2cs converted at 2022 March 13 05:59:04 UTC
// import "cmd/compile/internal/types" ==> using types = go.cmd.compile.@internal.types_package
// Original source: C:\Program Files\Go\src\cmd\compile\internal\types\algkind_string.go
namespace go.cmd.compile.@internal;

using strconv = strconv_package;

public static partial class types_package {

private static void _() { 
    // An "invalid array index" compiler error signifies that the constant values have changed.
    // Re-run the stringer command to generate them again.
    var x = default;
    _ = x[ANOEQ - 0];
    _ = x[AMEM0 - 1];
    _ = x[AMEM8 - 2];
    _ = x[AMEM16 - 3];
    _ = x[AMEM32 - 4];
    _ = x[AMEM64 - 5];
    _ = x[AMEM128 - 6];
    _ = x[ASTRING - 7];
    _ = x[AINTER - 8];
    _ = x[ANILINTER - 9];
    _ = x[AFLOAT32 - 10];
    _ = x[AFLOAT64 - 11];
    _ = x[ACPLX64 - 12];
    _ = x[ACPLX128 - 13];
    _ = x[AMEM - 100];
    _ = x[ASPECIAL - -1];
}

private static readonly @string _AlgKind_name_0 = "SPECIALNOEQMEM0MEM8MEM16MEM32MEM64MEM128STRINGINTERNILINTERFLOAT32FLOAT64CPLX64CPLX128";
private static readonly @string _AlgKind_name_1 = "MEM";

private static array<byte> _AlgKind_index_0 = new array<byte>(new byte[] { 0, 7, 11, 15, 19, 24, 29, 34, 40, 46, 51, 59, 66, 73, 79, 86 });

public static @string String(this AlgKind i) {

    if (-1 <= i && i <= 13) 
        i -= -1;
        return _AlgKind_name_0[(int)_AlgKind_index_0[i]..(int)_AlgKind_index_0[i + 1]];
    else if (i == 100) 
        return _AlgKind_name_1;
    else 
        return "AlgKind(" + strconv.FormatInt(int64(i), 10) + ")";
    }

} // end types_package
