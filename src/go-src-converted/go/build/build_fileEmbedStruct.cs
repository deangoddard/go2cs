//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constraint = go.go.build.constraint_package;
using doc = go.go.doc_package;
using token = go.go.token_package;
using buildcfg = go.@internal.buildcfg_package;
using exec = go.@internal.execabs_package;
using goroot = go.@internal.goroot_package;
using goversion = go.@internal.goversion_package;
using io = go.io_package;
using fs = go.io.fs_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using pathpkg = go.path_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class build_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fileEmbed
        {
            // Constructors
            public fileEmbed(NilType _)
            {
                this.pattern = default;
                this.pos = default;
            }

            public fileEmbed(@string pattern = default, token.Position pos = default)
            {
                this.pattern = pattern;
                this.pos = pos;
            }

            // Enable comparisons between nil and fileEmbed struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileEmbed value, NilType nil) => value.Equals(default(fileEmbed));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileEmbed value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileEmbed value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileEmbed value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileEmbed(NilType nil) => default(fileEmbed);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fileEmbed fileEmbed_cast(dynamic value)
        {
            return new fileEmbed(value.pattern, value.pos);
        }
    }
}}