//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class flag_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct float64Value
        {
            // Value of the float64Value struct
            private readonly double m_value;
            
            public float64Value(double value) => m_value = value;

            // Enable implicit conversions between double and float64Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator float64Value(double value) => new float64Value(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator double(float64Value value) => value.m_value;
            
            // Enable comparisons between nil and float64Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(float64Value value, NilType nil) => value.Equals(default(float64Value));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(float64Value value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, float64Value value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, float64Value value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator float64Value(NilType nil) => default(float64Value);
        }
    }
}
