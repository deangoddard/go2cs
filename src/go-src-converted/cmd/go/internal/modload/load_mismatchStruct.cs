//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using fs = go.io.fs_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using mvs = go.cmd.go.@internal.mvs_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mismatch
        {
            // Constructors
            public mismatch(NilType _)
            {
                this.mod = default;
                this.err = default;
            }

            public mismatch(module.Version mod = default, error err = default)
            {
                this.mod = mod;
                this.err = err;
            }

            // Enable comparisons between nil and mismatch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mismatch value, NilType nil) => value.Equals(default(mismatch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mismatch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mismatch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mismatch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mismatch(NilType nil) => default(mismatch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mismatch mismatch_cast(dynamic value)
        {
            return new mismatch(value.mod, value.err);
        }
    }
}}}}