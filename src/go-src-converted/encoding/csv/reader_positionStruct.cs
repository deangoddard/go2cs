//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class csv_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct position
        {
            // Constructors
            public position(NilType _)
            {
                this.line = default;
                this.col = default;
            }

            public position(nint line = default, nint col = default)
            {
                this.line = line;
                this.col = col;
            }

            // Enable comparisons between nil and position struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(position value, NilType nil) => value.Equals(default(position));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(position value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, position value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, position value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator position(NilType nil) => default(position);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static position position_cast(dynamic value)
        {
            return new position(value.line, value.col);
        }
    }
}}