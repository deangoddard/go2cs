//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace hash
{
    public static partial class fnv_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct sum64
        {
            // Value of the sum64 struct
            private readonly ulong m_value;
            
            public sum64(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and sum64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum64(ulong value) => new sum64(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(sum64 value) => value.m_value;
            
            // Enable comparisons between nil and sum64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sum64 value, NilType nil) => value.Equals(default(sum64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sum64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sum64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sum64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum64(NilType nil) => default(sum64);
        }
    }
}}
