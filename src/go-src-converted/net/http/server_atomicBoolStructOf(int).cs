//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct atomicBool
        {
            // Value of the atomicBool struct
            private readonly int m_value;
            
            public atomicBool(int value) => m_value = value;

            // Enable implicit conversions between int and atomicBool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator atomicBool(int value) => new atomicBool(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(atomicBool value) => value.m_value;
            
            // Enable comparisons between nil and atomicBool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(atomicBool value, NilType nil) => value.Equals(default(atomicBool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(atomicBool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, atomicBool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, atomicBool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator atomicBool(NilType nil) => default(atomicBool);
        }
    }
}}
