// Code generated by "stringer -type EType -trimprefix T"; DO NOT EDIT.

// package types -- go2cs converted at 2020 October 09 05:24:10 UTC
// import "cmd/compile/internal/types" ==> using types = go.cmd.compile.@internal.types_package
// Original source: C:\Go\src\cmd\compile\internal\types\etype_string.go
using strconv = go.strconv_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        private static void _()
        { 
            // An "invalid array index" compiler error signifies that the constant values have changed.
            // Re-run the stringer command to generate them again.
            var x = default;
            _ = x[Txxx - 0L];
            _ = x[TINT8 - 1L];
            _ = x[TUINT8 - 2L];
            _ = x[TINT16 - 3L];
            _ = x[TUINT16 - 4L];
            _ = x[TINT32 - 5L];
            _ = x[TUINT32 - 6L];
            _ = x[TINT64 - 7L];
            _ = x[TUINT64 - 8L];
            _ = x[TINT - 9L];
            _ = x[TUINT - 10L];
            _ = x[TUINTPTR - 11L];
            _ = x[TCOMPLEX64 - 12L];
            _ = x[TCOMPLEX128 - 13L];
            _ = x[TFLOAT32 - 14L];
            _ = x[TFLOAT64 - 15L];
            _ = x[TBOOL - 16L];
            _ = x[TPTR - 17L];
            _ = x[TFUNC - 18L];
            _ = x[TSLICE - 19L];
            _ = x[TARRAY - 20L];
            _ = x[TSTRUCT - 21L];
            _ = x[TCHAN - 22L];
            _ = x[TMAP - 23L];
            _ = x[TINTER - 24L];
            _ = x[TFORW - 25L];
            _ = x[TANY - 26L];
            _ = x[TSTRING - 27L];
            _ = x[TUNSAFEPTR - 28L];
            _ = x[TIDEAL - 29L];
            _ = x[TNIL - 30L];
            _ = x[TBLANK - 31L];
            _ = x[TFUNCARGS - 32L];
            _ = x[TCHANARGS - 33L];
            _ = x[TSSA - 34L];
            _ = x[TTUPLE - 35L];
            _ = x[NTYPE - 36L];

        }

        private static readonly @string _EType_name = (@string)"xxxINT8UINT8INT16UINT16INT32UINT32INT64UINT64INTUINTUINTPTRCOMPLEX64COMPLEX128FLOAT32FLOAT64BOOLPTRFUNCSLICEARRAYSTRUCTCHANMAPINTERFORWANYSTRINGUNSAFEPTRIDEALNILBLANKFUNCARGSCHANARGSSSATUPLENTYPE";



        private static array<byte> _EType_index = new array<byte>(new byte[] { 0, 3, 7, 12, 17, 23, 28, 34, 39, 45, 48, 52, 59, 68, 78, 85, 92, 96, 99, 103, 108, 113, 119, 123, 126, 131, 135, 138, 144, 153, 158, 161, 166, 174, 182, 185, 190, 195 });

        public static @string String(this EType i)
        {
            if (i >= EType(len(_EType_index) - 1L))
            {
                return "EType(" + strconv.FormatInt(int64(i), 10L) + ")";
            }

            return _EType_name[_EType_index[i].._EType_index[i + 1L]];

        }
    }
}}}}
