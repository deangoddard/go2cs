//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using lazyregexp = go.@internal.lazyregexp_package;
using io = go.io_package;
using fs = go.io.fs_package;
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
        private partial struct deleteCloser
        {
            // Constructors
            public deleteCloser(NilType _)
            {
                this.File> = default;
            }

            public deleteCloser(ref ptr<os.File> File> = default)
            {
                this.File> = File>;
            }

            // Enable comparisons between nil and deleteCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(deleteCloser value, NilType nil) => value.Equals(default(deleteCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(deleteCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, deleteCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, deleteCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator deleteCloser(NilType nil) => default(deleteCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static deleteCloser deleteCloser_cast(dynamic value)
        {
            return new deleteCloser(ref value.File>);
        }
    }
}}}}}