//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:40:51 UTC
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
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Position
        {
            // Constructors
            public Position(NilType _)
            {
                this.Line = default;
                this.LineRune = default;
                this.Byte = default;
            }

            public Position(nint Line = default, nint LineRune = default, nint Byte = default)
            {
                this.Line = Line;
                this.LineRune = LineRune;
                this.Byte = Byte;
            }

            // Enable comparisons between nil and Position struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Position value, NilType nil) => value.Equals(default(Position));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Position value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Position value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Position value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Position(NilType nil) => default(Position);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Position Position_cast(dynamic value)
        {
            return new Position(value.Line, value.LineRune, value.Byte);
        }
    }
}}}}}}