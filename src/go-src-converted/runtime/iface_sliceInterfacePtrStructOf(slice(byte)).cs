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
        private partial struct sliceInterfacePtr
        {
            // Value of the sliceInterfacePtr struct
            private readonly slice<byte> m_value;

            public sliceInterfacePtr(slice<byte> value) => m_value = value;

            // Enable implicit conversions between slice<byte> and sliceInterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sliceInterfacePtr(slice<byte> value) => new sliceInterfacePtr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<byte>(sliceInterfacePtr value) => value.m_value;
            
            // Enable comparisons between nil and sliceInterfacePtr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sliceInterfacePtr value, NilType nil) => value.Equals(default(sliceInterfacePtr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sliceInterfacePtr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sliceInterfacePtr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sliceInterfacePtr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sliceInterfacePtr(NilType nil) => default(sliceInterfacePtr);
        }
    }
}
