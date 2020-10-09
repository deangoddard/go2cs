//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:44 UTC
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
        private partial struct stackpoolItem
        {
            // Constructors
            public stackpoolItem(NilType _)
            {
                this.mu = default;
                this.span = default;
            }

            public stackpoolItem(mutex mu = default, mSpanList span = default)
            {
                this.mu = mu;
                this.span = span;
            }

            // Enable comparisons between nil and stackpoolItem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackpoolItem value, NilType nil) => value.Equals(default(stackpoolItem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackpoolItem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackpoolItem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackpoolItem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackpoolItem(NilType nil) => default(stackpoolItem);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackpoolItem stackpoolItem_cast(dynamic value)
        {
            return new stackpoolItem(value.mu, value.span);
        }
    }
}