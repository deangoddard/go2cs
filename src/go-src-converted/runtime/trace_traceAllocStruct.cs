//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct traceAlloc
        {
            // Constructors
            public traceAlloc(NilType _)
            {
                this.head = default;
                this.off = default;
            }

            public traceAlloc(traceAllocBlockPtr head = default, System.UIntPtr off = default)
            {
                this.head = head;
                this.off = off;
            }

            // Enable comparisons between nil and traceAlloc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(traceAlloc value, NilType nil) => value.Equals(default(traceAlloc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(traceAlloc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, traceAlloc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, traceAlloc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator traceAlloc(NilType nil) => default(traceAlloc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static traceAlloc traceAlloc_cast(dynamic value)
        {
            return new traceAlloc(value.head, value.off);
        }
    }
}