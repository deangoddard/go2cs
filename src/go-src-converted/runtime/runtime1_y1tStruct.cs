//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:11:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytealg = go.@internal.bytealg_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct y1t
        {
            // Constructors
            public y1t(NilType _)
            {
                this.x1 = default;
                this.y = default;
            }

            public y1t(x1t x1 = default, byte y = default)
            {
                this.x1 = x1;
                this.y = y;
            }

            // Enable comparisons between nil and y1t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(y1t value, NilType nil) => value.Equals(default(y1t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(y1t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, y1t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, y1t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator y1t(NilType nil) => default(y1t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static y1t y1t_cast(dynamic value)
        {
            return new y1t(value.x1, value.y);
        }
    }
}