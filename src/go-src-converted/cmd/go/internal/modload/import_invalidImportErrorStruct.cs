//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using goroot = go.@internal.goroot_package;
using fs = go.io.fs_package;
using os = go.os_package;
using pathpkg = go.path_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
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
        private partial struct invalidImportError
        {
            // Constructors
            public invalidImportError(NilType _)
            {
                this.importPath = default;
                this.err = default;
            }

            public invalidImportError(@string importPath = default, error err = default)
            {
                this.importPath = importPath;
                this.err = err;
            }

            // Enable comparisons between nil and invalidImportError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(invalidImportError value, NilType nil) => value.Equals(default(invalidImportError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(invalidImportError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, invalidImportError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, invalidImportError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator invalidImportError(NilType nil) => default(invalidImportError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static invalidImportError invalidImportError_cast(dynamic value)
        {
            return new invalidImportError(value.importPath, value.err);
        }
    }
}}}}