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
        private partial struct profIndex
        {
            // Value of the profIndex struct
            private readonly ulong m_value;
            
            public profIndex(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and profIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profIndex(ulong value) => new profIndex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(profIndex value) => value.m_value;
            
            // Enable comparisons between nil and profIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(profIndex value, NilType nil) => value.Equals(default(profIndex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(profIndex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, profIndex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, profIndex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profIndex(NilType nil) => default(profIndex);
        }
    }
}
