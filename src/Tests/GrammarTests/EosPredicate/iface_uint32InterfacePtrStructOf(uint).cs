//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 03:43:36 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct uint32InterfacePtr
        {
            // Value of the uint32InterfacePtr struct
            private readonly uint m_value;
            
            public uint32InterfacePtr(uint value) => m_value = value;

            // Enable implicit conversions between uint and uint32InterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint32InterfacePtr(uint value) => new uint32InterfacePtr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(uint32InterfacePtr value) => value.m_value;
            
            // Enable comparisons between nil and uint32InterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uint32InterfacePtr value, NilType nil) => value.Equals(default(uint32InterfacePtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uint32InterfacePtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uint32InterfacePtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uint32InterfacePtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint32InterfacePtr(NilType nil) => default(uint32InterfacePtr);
        }
    }
}
