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
        public partial struct ComplexType
        {
            // Value of the ComplexType struct
            private readonly complex64 m_value;
            
            public ComplexType(complex64 value) => m_value = value;

            // Enable implicit conversions between complex64 and ComplexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ComplexType(complex64 value) => new ComplexType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator complex64(ComplexType value) => value.m_value;
            
            // Enable comparisons between nil and ComplexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ComplexType value, NilType nil) => value.Equals(default(ComplexType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ComplexType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ComplexType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ComplexType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ComplexType(NilType nil) => default(ComplexType);
        }
    }
}
