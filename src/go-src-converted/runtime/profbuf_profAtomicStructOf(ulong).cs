//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:11:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct profAtomic
        {
            // Value of the profAtomic struct
            private readonly ulong m_value;
            
            public profAtomic(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and profAtomic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profAtomic(ulong value) => new profAtomic(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(profAtomic value) => value.m_value;
            
            // Enable comparisons between nil and profAtomic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(profAtomic value, NilType nil) => value.Equals(default(profAtomic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(profAtomic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, profAtomic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, profAtomic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profAtomic(NilType nil) => default(profAtomic);
        }
    }
}
