//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:24:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using math = go.runtime.@internal.math_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct linearAlloc
        {
            // Constructors
            public linearAlloc(NilType _)
            {
                this.next = default;
                this.mapped = default;
                this.end = default;
                this.mapMemory = default;
            }

            public linearAlloc(System.UIntPtr next = default, System.UIntPtr mapped = default, System.UIntPtr end = default, bool mapMemory = default)
            {
                this.next = next;
                this.mapped = mapped;
                this.end = end;
                this.mapMemory = mapMemory;
            }

            // Enable comparisons between nil and linearAlloc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(linearAlloc value, NilType nil) => value.Equals(default(linearAlloc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(linearAlloc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, linearAlloc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, linearAlloc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator linearAlloc(NilType nil) => default(linearAlloc);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static linearAlloc linearAlloc_cast(dynamic value)
        {
            return new linearAlloc(value.next, value.mapped, value.end, value.mapMemory);
        }
    }
}