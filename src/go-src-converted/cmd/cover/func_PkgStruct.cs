//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:28:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using cover = go.golang.org.x.tools.cover_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Pkg
        {
            // Constructors
            public Pkg(NilType _)
            {
                this.ImportPath = default;
                this.Dir = default;
            }

            public Pkg(@string ImportPath = default, @string Dir = default)
            {
                this.ImportPath = ImportPath;
                this.Dir = Dir;
            }

            // Enable comparisons between nil and Pkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Pkg value, NilType nil) => value.Equals(default(Pkg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Pkg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Pkg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Pkg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pkg(NilType nil) => default(Pkg);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Pkg Pkg_cast(dynamic value)
        {
            return new Pkg(value.ImportPath, value.Dir);
        }
    }
}