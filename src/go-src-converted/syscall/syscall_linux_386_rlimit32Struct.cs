//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rlimit32
        {
            // Constructors
            public rlimit32(NilType _)
            {
                this.Cur = default;
                this.Max = default;
            }

            public rlimit32(uint Cur = default, uint Max = default)
            {
                this.Cur = Cur;
                this.Max = Max;
            }

            // Enable comparisons between nil and rlimit32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rlimit32 value, NilType nil) => value.Equals(default(rlimit32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rlimit32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rlimit32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rlimit32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rlimit32(NilType nil) => default(rlimit32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rlimit32 rlimit32_cast(dynamic value)
        {
            return new rlimit32(value.Cur, value.Max);
        }
    }
}