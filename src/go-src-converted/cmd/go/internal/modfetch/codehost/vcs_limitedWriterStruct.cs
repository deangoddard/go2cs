//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using lazyregexp = go.@internal.lazyregexp_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using par = go.cmd.go.@internal.par_package;
using str = go.cmd.go.@internal.str_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace modfetch
{
    public static partial class codehost_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct limitedWriter
        {
            // Constructors
            public limitedWriter(NilType _)
            {
                this.W = default;
                this.N = default;
                this.ErrLimitReached = default;
            }

            public limitedWriter(io.Writer W = default, long N = default, error ErrLimitReached = default)
            {
                this.W = W;
                this.N = N;
                this.ErrLimitReached = ErrLimitReached;
            }

            // Enable comparisons between nil and limitedWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(limitedWriter value, NilType nil) => value.Equals(default(limitedWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(limitedWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, limitedWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, limitedWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator limitedWriter(NilType nil) => default(limitedWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static limitedWriter limitedWriter_cast(dynamic value)
        {
            return new limitedWriter(value.W, value.N, value.ErrLimitReached);
        }
    }
}}}}}