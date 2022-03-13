//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:34:17 UTC
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
    public static partial class dsa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct ParameterSizes
        {
            // Value of the ParameterSizes struct
            private readonly nint m_value;
            
            public ParameterSizes(nint value) => m_value = value;

            // Enable implicit conversions between nint and ParameterSizes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ParameterSizes(nint value) => new ParameterSizes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(ParameterSizes value) => value.m_value;
            
            // Enable comparisons between nil and ParameterSizes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ParameterSizes value, NilType nil) => value.Equals(default(ParameterSizes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ParameterSizes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ParameterSizes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ParameterSizes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ParameterSizes(NilType nil) => default(ParameterSizes);
        }
    }
}}
