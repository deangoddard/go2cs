//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:20 UTC
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
    public static partial class rc4_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct KeySizeError
        {
            // Value of the KeySizeError struct
            private readonly nint m_value;
            
            public KeySizeError(nint value) => m_value = value;

            // Enable implicit conversions between nint and KeySizeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator KeySizeError(nint value) => new KeySizeError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(KeySizeError value) => value.m_value;
            
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
