//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:17:15 UTC
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
using ast = go.go.ast_package;
using build = go.go.build_package;
using doc = go.go.doc_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using lazytemplate = go.@internal.lazytemplate_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using fsys = go.cmd.go.@internal.fsys_package;
using str = go.cmd.go.@internal.str_package;
using trace = go.cmd.go.@internal.trace_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct coverInfo
        {
            // Constructors
            public coverInfo(NilType _)
            {
                this.Package = default;
                this.Vars = default;
            }

            public coverInfo(ref ptr<Package> Package = default, map<@string, ptr<CoverVar>> Vars = default)
            {
                this.Package = Package;
                this.Vars = Vars;
            }

            // Enable comparisons between nil and coverInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(coverInfo value, NilType nil) => value.Equals(default(coverInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(coverInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, coverInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, coverInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator coverInfo(NilType nil) => default(coverInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static coverInfo coverInfo_cast(dynamic value)
        {
            return new coverInfo(ref value.Package, value.Vars);
        }
    }
}}}}