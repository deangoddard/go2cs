//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class issue31540_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct A1
        {
            // Value of the A1 struct
            private readonly X m_value;
            
            public A1(X value) => m_value = value;

            // Enable implicit conversions between X and A1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A1(X value) => new A1(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator X(A1 value) => value.m_value;
            
            // Enable comparisons between nil and A1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A1 value, NilType nil) => value.Equals(default(A1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A1(NilType nil) => default(A1);
        }
    }
}}}
