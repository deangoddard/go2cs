//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:15:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct token
        {
            // Value of the token struct
            private readonly uint m_value;
            
            public token(uint value) => m_value = value;

            // Enable implicit conversions between uint and token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator token(uint value) => new token(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(token value) => value.m_value;
            
            // Enable comparisons between nil and token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(token value, NilType nil) => value.Equals(default(token));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(token value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, token value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, token value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator token(NilType nil) => default(token);
        }
    }
}}
