//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:18:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

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
            return new gsignalStack();
        }
    }
}