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
        private partial struct findpkgKey
        {
            // Constructors
            public findpkgKey(NilType _)
            {
                this.importPath = default;
                this.fromDir = default;
                this.mode = default;
            }

            public findpkgKey(@string importPath = default, @string fromDir = default, build.ImportMode mode = default)
            {
                this.importPath = importPath;
                this.fromDir = fromDir;
                this.mode = mode;
            }

            // Enable comparisons between nil and findpkgKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(findpkgKey value, NilType nil) => value.Equals(default(findpkgKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(findpkgKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, findpkgKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, findpkgKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator findpkgKey(NilType nil) => default(findpkgKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static findpkgKey findpkgKey_cast(dynamic value)
        {
            return new findpkgKey(value.importPath, value.fromDir, value.mode);
        }
    }
}}}}}