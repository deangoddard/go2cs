//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:47:10 UTC
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
        private partial struct spanSetBlock
        {
            // Constructors
            public spanSetBlock(NilType _)
            {
                this.lfnode = default;
                this.popped = default;
                this.spans = default;
            }

            public spanSetBlock(lfnode lfnode = default, uint popped = default, array<ptr<mspan>> spans = default)
            {
                this.lfnode = lfnode;
                this.popped = popped;
                this.spans = spans;
            }

            // Enable comparisons between nil and spanSetBlock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(spanSetBlock value, NilType nil) => value.Equals(default(spanSetBlock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(spanSetBlock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, spanSetBlock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, spanSetBlock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator spanSetBlock(NilType nil) => default(spanSetBlock);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static spanSetBlock spanSetBlock_cast(dynamic value)
        {
            return new spanSetBlock(value.lfnode, value.popped, value.spans);
        }
    }
}