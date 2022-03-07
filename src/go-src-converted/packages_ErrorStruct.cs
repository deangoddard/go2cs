//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using parser = go.go.parser_package;
using scanner = go.go.scanner_package;
using token = go.go.token_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using gcexportdata = go.golang.org.x.tools.go.gcexportdata_package;
using gocommand = go.golang.org.x.tools.@internal.gocommand_package;
using packagesinternal = go.golang.org.x.tools.@internal.packagesinternal_package;
using typesinternal = go.golang.org.x.tools.@internal.typesinternal_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class packages_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Error
        {
            // Constructors
            public Error(NilType _)
            {
                this.Pos = default;
                this.Msg = default;
                this.Kind = default;
            }

            public Error(@string Pos = default, @string Msg = default, ErrorKind Kind = default)
            {
                this.Pos = Pos;
                this.Msg = Msg;
                this.Kind = Kind;
            }

            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Error Error_cast(dynamic value)
        {
            return new Error(value.Pos, value.Msg, value.Kind);
        }
    }
}}}}}