//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:45 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uint16
        {
            // Value of the uint16 struct
            private readonly ushort m_value;
            
            public uint16(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and uint16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint16(ushort value) => new uint16(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(uint16 value) => value.m_value;
            
            // Enable comparisons between nil and uint16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uint16 value, NilType nil) => value.Equals(default(uint16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uint16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uint16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uint16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint16(NilType nil) => default(uint16);
        }
    }
}
