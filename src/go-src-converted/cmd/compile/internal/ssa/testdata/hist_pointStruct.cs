//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:24:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct point
        {
            // Constructors
            public point(NilType _)
            {
                this.x = default;
                this.y = default;
            }

            public point(long x = default, long y = default)
            {
                this.x = x;
                this.y = y;
            }

            // Enable comparisons between nil and point struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(point value, NilType nil) => value.Equals(default(point));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(point value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, point value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, point value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator point(NilType nil) => default(point);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static point point_cast(dynamic value)
        {
            return new point(value.x, value.y);
        }
    }
}