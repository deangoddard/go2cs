//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:28 UTC
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
using fs = go.io.fs_package;
using os = go.os_package;
using pathpkg = go.path_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using trace = go.cmd.go.@internal.trace_package;
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
        private partial struct queryDisabledError
        {
            // Constructors
            public queryDisabledError(NilType _)
            {
            }
            // Enable comparisons between nil and queryDisabledError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(queryDisabledError value, NilType nil) => value.Equals(default(queryDisabledError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(queryDisabledError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, queryDisabledError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, queryDisabledError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator queryDisabledError(NilType nil) => default(queryDisabledError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static queryDisabledError queryDisabledError_cast(dynamic value)
        {
            return new queryDisabledError();
        }
    }
}}}}