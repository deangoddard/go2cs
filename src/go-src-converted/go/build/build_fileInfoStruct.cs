//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:22 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct fileInfo
        {
            // Constructors
            public fileInfo(NilType _)
            {
                this.name = default;
                this.header = default;
                this.fset = default;
                this.parsed = default;
                this.parseErr = default;
                this.imports = default;
                this.embeds = default;
                this.embedErr = default;
            }

            public fileInfo(@string name = default, slice<byte> header = default, ref ptr<token.FileSet> fset = default, ref ptr<ast.File> parsed = default, error parseErr = default, slice<fileImport> imports = default, slice<fileEmbed> embeds = default, error embedErr = default)
            {
                this.name = name;
                this.header = header;
                this.fset = fset;
                this.parsed = parsed;
                this.parseErr = parseErr;
                this.imports = imports;
                this.embeds = embeds;
                this.embedErr = embedErr;
            }

            // Enable comparisons between nil and fileInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileInfo value, NilType nil) => value.Equals(default(fileInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileInfo(NilType nil) => default(fileInfo);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static fileInfo fileInfo_cast(dynamic value)
        {
            return new fileInfo(value.name, value.header, ref value.fset, ref value.parsed, value.parseErr, value.imports, value.embeds, value.embedErr);
        }
    }
}}