//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:36:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class mime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct WordEncoder
        {
            // Value of the WordEncoder struct
            private readonly byte m_value;
            
            public WordEncoder(byte value) => m_value = value;

            // Enable implicit conversions between byte and WordEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator WordEncoder(byte value) => new WordEncoder(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(WordEncoder value) => value.m_value;
            
            // Enable comparisons between nil and WordEncoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(WordEncoder value, NilType nil) => value.Equals(default(WordEncoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(WordEncoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, WordEncoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, WordEncoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator WordEncoder(NilType nil) => default(WordEncoder);
        }
    }
}
