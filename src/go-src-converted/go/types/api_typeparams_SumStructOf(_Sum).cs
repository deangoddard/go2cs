//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Sum
        {
            // Value of the Sum struct
            private readonly _Sum m_value;
            
            public Sum(_Sum value) => m_value = value;

            // Enable implicit conversions between _Sum and Sum struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sum(_Sum value) => new Sum(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Sum(Sum value) => value.m_value;
            
            // Enable comparisons between nil and Sum struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sum value, NilType nil) => value.Equals(default(Sum));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sum value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sum value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sum value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sum(NilType nil) => default(Sum);
        }
    }
}}
