//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringEncoder
        {
            // Value of the stringEncoder struct
            private readonly @string m_value;
            
            public stringEncoder(@string value) => m_value = value;

            // Enable implicit conversions between @string and stringEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringEncoder(@string value) => new stringEncoder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(stringEncoder value) => value.m_value;
            
            // Enable comparisons between nil and stringEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringEncoder value, NilType nil) => value.Equals(default(stringEncoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringEncoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringEncoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringEncoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringEncoder(NilType nil) => default(stringEncoder);
        }
    }
}}
