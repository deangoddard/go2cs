//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:02:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct posetEdge
        {
            // Value of the posetEdge struct
            private readonly uint m_value;
            
            public posetEdge(uint value) => m_value = value;

            // Enable implicit conversions between uint and posetEdge struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator posetEdge(uint value) => new posetEdge(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(posetEdge value) => value.m_value;
            
            // Enable comparisons between nil and posetEdge struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(posetEdge value, NilType nil) => value.Equals(default(posetEdge));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(posetEdge value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, posetEdge value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, posetEdge value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator posetEdge(NilType nil) => default(posetEdge);
        }
    }
}}}}
