//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct float64
        {
            // Value of the float64 struct
            private readonly double m_value;
            
            public float64(double value) => m_value = value;

            // Enable implicit conversions between double and float64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator float64(double value) => new float64(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator double(float64 value) => value.m_value;
            
            // Enable comparisons between nil and float64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(float64 value, NilType nil) => value.Equals(default(float64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(float64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, float64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, float64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator float64(NilType nil) => default(float64);
        }
    }
}
