//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:51 UTC
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
        private partial struct importError
        {
            // Constructors
            public importError(NilType _)
            {
                this.path = default;
                this.err = default;
            }

            public importError(@string path = default, error err = default)
            {
                this.path = path;
                this.err = err;
            }

            // Enable comparisons between nil and importError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importError value, NilType nil) => value.Equals(default(importError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importError(NilType nil) => default(importError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importError importError_cast(dynamic value)
        {
            return new importError(value.path, value.err);
        }
    }
}}}}}