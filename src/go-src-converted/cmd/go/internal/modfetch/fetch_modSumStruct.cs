//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:32:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using context = go.context_package;
using sha256 = go.crypto.sha256_package;
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using par = go.cmd.go.@internal.par_package;
using robustio = go.cmd.go.@internal.robustio_package;
using trace = go.cmd.go.@internal.trace_package;
using module = go.golang.org.x.mod.module_package;
using dirhash = go.golang.org.x.mod.sumdb.dirhash_package;
using modzip = go.golang.org.x.mod.zip_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct modSum
        {
            // Constructors
            public modSum(NilType _)
            {
                this.mod = default;
                this.sum = default;
            }

            public modSum(module.Version mod = default, @string sum = default)
            {
                this.mod = mod;
                this.sum = sum;
            }

            // Enable comparisons between nil and modSum struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(modSum value, NilType nil) => value.Equals(default(modSum));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(modSum value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, modSum value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, modSum value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator modSum(NilType nil) => default(modSum);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static modSum modSum_cast(dynamic value)
        {
            return new modSum(value.mod, value.sum);
        }
    }
}}}}