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
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stack
        {
            // Constructors
            public stack(NilType _)
            {
                this.lo = default;
                this.hi = default;
            }

            public stack(System.UIntPtr lo = default, System.UIntPtr hi = default)
            {
                this.lo = lo;
                this.hi = hi;
            }

            // Enable comparisons between nil and stack struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stack value, NilType nil) => value.Equals(default(stack));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stack value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stack value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stack value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stack(NilType nil) => default(stack);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stack stack_cast(dynamic value)
        {
            return new stack(value.lo, value.hi);
        }
    }
}