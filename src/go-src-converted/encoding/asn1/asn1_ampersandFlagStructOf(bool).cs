//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:41 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct ampersandFlag
        {
            // Value of the ampersandFlag struct
            private readonly bool m_value;
            
            public ampersandFlag(bool value) => m_value = value;

            // Enable implicit conversions between bool and ampersandFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ampersandFlag(bool value) => new ampersandFlag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bool(ampersandFlag value) => value.m_value;
            
            // Enable comparisons between nil and ampersandFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ampersandFlag value, NilType nil) => value.Equals(default(ampersandFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ampersandFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ampersandFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ampersandFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ampersandFlag(NilType nil) => default(ampersandFlag);
        }
    }
}}
