//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using scanner = go.go.scanner_package;
using token = go.go.token_package;
using goroot = go.@internal.goroot_package;
using fs = go.io.fs_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using fsys = go.cmd.go.@internal.fsys_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using modinfo = go.cmd.go.@internal.modinfo_package;
using modload = go.cmd.go.@internal.modload_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using trace = go.cmd.go.@internal.trace_package;
using sys = go.cmd.@internal.sys_package;
using modfile = go.golang.org.x.mod.modfile_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct NoGoError
        {
            // Constructors
            public NoGoError(NilType _)
            {
                this.Package = default;
            }

            public NoGoError(ref ptr<Package> Package = default)
            {
                this.Package = Package;
            }

            // Enable comparisons between nil and NoGoError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NoGoError value, NilType nil) => value.Equals(default(NoGoError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NoGoError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NoGoError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NoGoError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NoGoError(NilType nil) => default(NoGoError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static NoGoError NoGoError_cast(dynamic value)
        {
            return new NoGoError(ref value.Package);
        }
    }
}}}}