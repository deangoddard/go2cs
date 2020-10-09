// Code generated by "stringer -type AlgKind -trimprefix A"; DO NOT EDIT.

// package gc -- go2cs converted at 2020 October 09 05:40:35 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Go\src\cmd\compile\internal\gc\algkind_string.go
using strconv = go.strconv_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        private static void _()
        { 
            // An "invalid array index" compiler error signifies that the constant values have changed.
            // Re-run the stringer command to generate them again.
            var x = default;
            _ = x[ANOEQ - 0L];
            _ = x[AMEM0 - 1L];
            _ = x[AMEM8 - 2L];
            _ = x[AMEM16 - 3L];
            _ = x[AMEM32 - 4L];
            _ = x[AMEM64 - 5L];
            _ = x[AMEM128 - 6L];
            _ = x[ASTRING - 7L];
            _ = x[AINTER - 8L];
            _ = x[ANILINTER - 9L];
            _ = x[AFLOAT32 - 10L];
            _ = x[AFLOAT64 - 11L];
            _ = x[ACPLX64 - 12L];
            _ = x[ACPLX128 - 13L];
            _ = x[AMEM - 100L];
            _ = x[ASPECIAL - -1L];

        }

        private static readonly @string _AlgKind_name_0 = (@string)"SPECIALNOEQMEM0MEM8MEM16MEM32MEM64MEM128STRINGINTERNILINTERFLOAT32FLOAT64CPLX64CPLX128";
        private static readonly @string _AlgKind_name_1 = (@string)"MEM";


        private static array<byte> _AlgKind_index_0 = new array<byte>(new byte[] { 0, 7, 11, 15, 19, 24, 29, 34, 40, 46, 51, 59, 66, 73, 79, 86 });

        public static @string String(this AlgKind i)
        {

            if (-1L <= i && i <= 13L) 
                i -= -1L;
                return _AlgKind_name_0[_AlgKind_index_0[i].._AlgKind_index_0[i + 1L]];
            else if (i == 100L) 
                return _AlgKind_name_1;
            else 
                return "AlgKind(" + strconv.FormatInt(int64(i), 10L) + ")";
            
        }
    }
}}}}
