//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:28:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class aes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct KeySizeError
        {
            // Value of the KeySizeError struct
            private readonly long m_value;

            public KeySizeError(long value) => m_value = value;

            // Enable implicit conversions between long and KeySizeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeySizeError(long value) => new KeySizeError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(KeySizeError value) => value.m_value;
            
            // Enable comparisons between nil and KeySizeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(KeySizeError value, NilType nil) => value.Equals(default(KeySizeError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(KeySizeError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, KeySizeError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, KeySizeError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeySizeError(NilType nil) => default(KeySizeError);
        }
    }
}}
