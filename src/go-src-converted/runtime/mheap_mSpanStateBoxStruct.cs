//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mSpanStateBox
        {
            // Constructors
            public mSpanStateBox(NilType _)
            {
                this.s = default;
            }

            public mSpanStateBox(mSpanState s = default)
            {
                this.s = s;
            }

            // Enable comparisons between nil and mSpanStateBox struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mSpanStateBox value, NilType nil) => value.Equals(default(mSpanStateBox));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mSpanStateBox value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mSpanStateBox value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mSpanStateBox value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mSpanStateBox(NilType nil) => default(mSpanStateBox);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mSpanStateBox mSpanStateBox_cast(dynamic value)
        {
            return new mSpanStateBox(value.s);
        }
    }
}