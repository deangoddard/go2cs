//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:03 UTC
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
        private partial struct gQueue
        {
            // Constructors
            public gQueue(NilType _)
            {
                this.head = default;
                this.tail = default;
            }

            public gQueue(guintptr head = default, guintptr tail = default)
            {
                this.head = head;
                this.tail = tail;
            }

            // Enable comparisons between nil and gQueue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gQueue value, NilType nil) => value.Equals(default(gQueue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gQueue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gQueue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gQueue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gQueue(NilType nil) => default(gQueue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gQueue gQueue_cast(dynamic value)
        {
            return new gQueue(value.head, value.tail);
        }
    }
}