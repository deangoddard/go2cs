//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct closure
        {
            // Constructors
            public closure(NilType _)
            {
                this.imp = default;
                this.info = default;
            }

            public closure(ref ptr<importer> imp = default, ref ptr<PackageInfo> info = default)
            {
                this.imp = imp;
                this.info = info;
            }

            // Enable comparisons between nil and closure struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(closure value, NilType nil) => value.Equals(default(closure));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(closure value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, closure value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, closure value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator closure(NilType nil) => default(closure);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static closure closure_cast(dynamic value)
        {
            return new closure(ref value.imp, ref value.info);
        }
    }
}}}}}