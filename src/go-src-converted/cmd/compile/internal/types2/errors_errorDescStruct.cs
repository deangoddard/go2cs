//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using syntax = go.cmd.compile.@internal.syntax_package;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorDesc
        {
            // Constructors
            public errorDesc(NilType _)
            {
                this.pos = default;
                this.format = default;
                this.args = default;
            }

            public errorDesc(syntax.Pos pos = default, @string format = default, slice<object> args = default)
            {
                this.pos = pos;
                this.format = format;
                this.args = args;
            }

            // Enable comparisons between nil and errorDesc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorDesc value, NilType nil) => value.Equals(default(errorDesc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorDesc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorDesc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorDesc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorDesc(NilType nil) => default(errorDesc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errorDesc errorDesc_cast(dynamic value)
        {
            return new errorDesc(value.pos, value.format, value.args);
        }
    }
}}}}