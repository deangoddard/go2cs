//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct uint16InterfacePtr
        {
            // Value of the uint16InterfacePtr struct
            private readonly ushort m_value;

            public uint16InterfacePtr(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and uint16InterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint16InterfacePtr(ushort value) => new uint16InterfacePtr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(uint16InterfacePtr value) => value.m_value;
            
            // Enable comparisons between nil and uint16InterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(uint16InterfacePtr value, NilType nil) => value.Equals(default(uint16InterfacePtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(uint16InterfacePtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, uint16InterfacePtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, uint16InterfacePtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint16InterfacePtr(NilType nil) => default(uint16InterfacePtr);
        }
    }
}
