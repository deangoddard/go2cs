//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using codehost = go.cmd.go.@internal.modfetch.codehost_package;
using par = go.cmd.go.@internal.par_package;
using renameio = go.cmd.go.@internal.renameio_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cached
        {
            // Constructors
            public cached(NilType _)
            {
                this.list = default;
                this.err = default;
            }

            public cached(slice<@string> list = default, error err = default)
            {
                this.list = list;
                this.err = err;
            }

            // Enable comparisons between nil and cached struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cached value, NilType nil) => value.Equals(default(cached));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cached value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cached value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cached value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cached(NilType nil) => default(cached);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cached cached_cast(dynamic value)
        {
            return new cached(value.list, value.err);
        }
    }
}}}}