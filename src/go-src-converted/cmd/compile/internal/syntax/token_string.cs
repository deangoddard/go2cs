// Code generated by "stringer -type token -linecomment"; DO NOT EDIT.

// package syntax -- go2cs converted at 2020 October 08 04:28:31 UTC
// import "cmd/compile/internal/syntax" ==> using syntax = go.cmd.compile.@internal.syntax_package
// Original source: C:\Go\src\cmd\compile\internal\syntax\token_string.go
using strconv = go.strconv_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        private static readonly @string _token_name = (@string)"EOFnameliteralopop=opop=:=<-*([{)]},;:....breakcasechanconstcontinuedefaultdeferelsefallthroughforfuncgogotoifimportinterfacemappackagerangereturnselectstructswitchtypevar";



        private static array<byte> _token_index = new array<byte>(new byte[] { 0, 3, 7, 14, 16, 19, 23, 24, 26, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 42, 47, 51, 55, 60, 68, 75, 80, 84, 95, 98, 102, 104, 108, 110, 116, 125, 128, 135, 140, 146, 152, 158, 164, 168, 171, 171 });

        private static @string String(this token i)
        {
            i -= 1L;
            if (i >= token(len(_token_index) - 1L))
            {
                return "token(" + strconv.FormatInt(int64(i + 1L), 10L) + ")";
            }

            return _token_name[_token_index[i].._token_index[i + 1L]];

        }
    }
}}}}