//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:02 UTC
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
        private partial struct cgothreadstart
        {
            // Constructors
            public cgothreadstart(NilType _)
            {
                this.g = default;
                this.tls = default;
                this.fn = default;
            }

            public cgothreadstart(guintptr g = default, ref ptr<ulong> tls = default, unsafe.Pointer fn = default)
            {
                this.g = g;
                this.tls = tls;
                this.fn = fn;
            }

            // Enable comparisons between nil and cgothreadstart struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cgothreadstart value, NilType nil) => value.Equals(default(cgothreadstart));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cgothreadstart value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cgothreadstart value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cgothreadstart value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cgothreadstart(NilType nil) => default(cgothreadstart);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cgothreadstart cgothreadstart_cast(dynamic value)
        {
            return new cgothreadstart(value.g, ref value.tls, value.fn);
        }
    }
}