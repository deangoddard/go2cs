//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct uint32
        {
            // Value of the uint32 struct
            private readonly uint m_value;
            
            public uint32(uint value) => m_value = value;

            // Enable implicit conversions between uint and uint32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint32(uint value) => new uint32(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(uint32 value) => value.m_value;
            
            // Enable comparisons between nil and uint32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uint32 value, NilType nil) => value.Equals(default(uint32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uint32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uint32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uint32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint32(NilType nil) => default(uint32);
        }
    }
}
