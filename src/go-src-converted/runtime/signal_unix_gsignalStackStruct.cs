//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:48:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gsignalStack
        {
            // Constructors
            public gsignalStack(NilType _)
            {
                this.stack = default;
                this.stackguard0 = default;
                this.stackguard1 = default;
                this.stktopsp = default;
            }

            public gsignalStack(stack stack = default, System.UIntPtr stackguard0 = default, System.UIntPtr stackguard1 = default, System.UIntPtr stktopsp = default)
            {
                this.stack = stack;
                this.stackguard0 = stackguard0;
                this.stackguard1 = stackguard1;
                this.stktopsp = stktopsp;
            }

            // Enable comparisons between nil and gsignalStack struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gsignalStack value, NilType nil) => value.Equals(default(gsignalStack));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gsignalStack value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gsignalStack value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gsignalStack value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gsignalStack(NilType nil) => default(gsignalStack);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gsignalStack gsignalStack_cast(dynamic value)
        {
            return new gsignalStack(value.stack, value.stackguard0, value.stackguard1, value.stktopsp);
        }
    }
}