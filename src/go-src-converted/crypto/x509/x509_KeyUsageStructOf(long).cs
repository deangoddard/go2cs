//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:32:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class x509_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct KeyUsage
        {
            // Value of the KeyUsage struct
            private readonly long m_value;

            public KeyUsage(long value) => m_value = value;

            // Enable implicit conversions between long and KeyUsage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeyUsage(long value) => new KeyUsage(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(KeyUsage value) => value.m_value;
            
            // Enable comparisons between nil and KeyUsage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(KeyUsage value, NilType nil) => value.Equals(default(KeyUsage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(KeyUsage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, KeyUsage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, KeyUsage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeyUsage(NilType nil) => default(KeyUsage);
        }
    }
}}
