//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:29:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using doc = go.go.doc_package;
using format = go.go.format_package;
using parser = go.go.parser_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using io = go.io_package;
using fs = go.io.fs_package;
using log = go.log_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Package
        {
            // Constructors
            public Package(NilType _)
            {
                this.writer = default;
                this.name = default;
                this.userPath = default;
                this.pkg = default;
                this.file = default;
                this.doc = default;
                this.build = default;
                this.typedValue = default;
                this.constructor = default;
                this.fs = default;
                this.buf = default;
            }

            public Package(io.Writer writer = default, @string name = default, @string userPath = default, ref ptr<ast.Package> pkg = default, ref ptr<ast.File> file = default, ref ptr<doc.Package> doc = default, ref ptr<build.Package> build = default, map<ptr<doc.Value>, bool> typedValue = default, map<ptr<doc.Func>, bool> constructor = default, ref ptr<token.FileSet> fs = default, pkgBuffer buf = default)
            {
                this.writer = writer;
                this.name = name;
                this.userPath = userPath;
                this.pkg = pkg;
                this.file = file;
                this.doc = doc;
                this.build = build;
                this.typedValue = typedValue;
                this.constructor = constructor;
                this.fs = fs;
                this.buf = buf;
            }

            // Enable comparisons between nil and Package struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Package value, NilType nil) => value.Equals(default(Package));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Package value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Package value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Package value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Package(NilType nil) => default(Package);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Package Package_cast(dynamic value)
        {
            return new Package(value.writer, value.name, value.userPath, ref value.pkg, ref value.file, ref value.doc, ref value.build, value.typedValue, value.constructor, ref value.fs, value.buf);
        }
    }
}