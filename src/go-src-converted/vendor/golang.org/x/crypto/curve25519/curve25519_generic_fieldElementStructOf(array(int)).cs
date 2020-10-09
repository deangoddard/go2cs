//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace crypto
{
    public static partial class curve25519_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fieldElement
        {
            // Value of the fieldElement struct
            private readonly array<int> m_value;

            public fieldElement(array<int> value) => m_value = value;

            // Enable implicit conversions between array<int> and fieldElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fieldElement(array<int> value) => new fieldElement(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<int>(fieldElement value) => value.m_value;
            
            // Enable comparisons between nil and fieldElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fieldElement value, NilType nil) => value.Equals(default(fieldElement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fieldElement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fieldElement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fieldElement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fieldElement(NilType nil) => default(fieldElement);
        }
    }
}}}}}
