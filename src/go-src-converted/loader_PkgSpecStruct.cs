//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using astutil = go.golang.org.x.tools.go.ast.astutil_package;
using cgo = go.golang.org.x.tools.go.@internal.cgo_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PkgSpec
        {
            // Constructors
            public PkgSpec(NilType _)
            {
                this.Path = default;
                this.Files = default;
                this.Filenames = default;
            }

            public PkgSpec(@string Path = default, slice<ptr<ast.File>> Files = default, slice<@string> Filenames = default)
            {
                this.Path = Path;
                this.Files = Files;
                this.Filenames = Filenames;
            }

            // Enable comparisons between nil and PkgSpec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PkgSpec value, NilType nil) => value.Equals(default(PkgSpec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PkgSpec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PkgSpec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PkgSpec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PkgSpec(NilType nil) => default(PkgSpec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PkgSpec PkgSpec_cast(dynamic value)
        {
            return new PkgSpec(value.Path, value.Files, value.Filenames);
        }
    }
}}}}}