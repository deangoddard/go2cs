//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:30 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct A2
        {
            // Value of the A2 struct
            private readonly A1 m_value;
            
            public A2(A1 value) => m_value = value;

            // Enable implicit conversions between A1 and A2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A2(A1 value) => new A2(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A1(A2 value) => value.m_value;
            
            // Enable comparisons between nil and A2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A2 value, NilType nil) => value.Equals(default(A2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A2(NilType nil) => default(A2);
        }
    }
}}}
