//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:26:46 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct x1t
        {
            // Constructors
            public x1t(NilType _)
            {
                this.x = default;
            }

            public x1t(byte x = default)
            {
                this.x = x;
            }

            // Enable comparisons between nil and x1t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(x1t value, NilType nil) => value.Equals(default(x1t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(x1t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, x1t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, x1t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator x1t(NilType nil) => default(x1t);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static x1t x1t_cast(dynamic value)
        {
            return new x1t(value.x);
        }
    }
}