//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using exec = go.@internal.execabs_package;
using io = go.io_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using _@unsafe_ = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class srcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Importer
        {
            // Constructors
            public Importer(NilType _)
            {
                this.ctxt = default;
                this.fset = default;
                this.sizes = default;
                this.packages = default;
            }

            public Importer(ref ptr<build.Context> ctxt = default, ref ptr<token.FileSet> fset = default, types.Sizes sizes = default, map<@string, ptr<types.Package>> packages = default)
            {
                this.ctxt = ctxt;
                this.fset = fset;
                this.sizes = sizes;
                this.packages = packages;
            }

            // Enable comparisons between nil and Importer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Importer value, NilType nil) => value.Equals(default(Importer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Importer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Importer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Importer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Importer(NilType nil) => default(Importer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Importer Importer_cast(dynamic value)
        {
            return new Importer(ref value.ctxt, ref value.fset, value.sizes, value.packages);
        }
    }
}}}