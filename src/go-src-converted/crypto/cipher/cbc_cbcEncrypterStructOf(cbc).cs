//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:30:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct cbcEncrypter
        {
            // Value of the cbcEncrypter struct
            private readonly cbc m_value;
            
            public cbcEncrypter(cbc value) => m_value = value;

            // Enable implicit conversions between cbc and cbcEncrypter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbcEncrypter(cbc value) => new cbcEncrypter(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbc(cbcEncrypter value) => value.m_value;
            
            // Enable comparisons between nil and cbcEncrypter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cbcEncrypter value, NilType nil) => value.Equals(default(cbcEncrypter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cbcEncrypter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cbcEncrypter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cbcEncrypter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cbcEncrypter(NilType nil) => default(cbcEncrypter);
        }
    }
}}
