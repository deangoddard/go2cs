//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:19:43 UTC
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
        public partial struct Enumerated
        {
            // Value of the Enumerated struct
            private readonly nint m_value;
            
            public Enumerated(nint value) => m_value = value;

            // Enable implicit conversions between nint and Enumerated struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Enumerated(nint value) => new Enumerated(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Enumerated value) => value.m_value;
            
            // Enable comparisons between nil and Enumerated struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Enumerated value, NilType nil) => value.Equals(default(Enumerated));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Enumerated value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Enumerated value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Enumerated value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Enumerated(NilType nil) => default(Enumerated);
        }
    }
}}