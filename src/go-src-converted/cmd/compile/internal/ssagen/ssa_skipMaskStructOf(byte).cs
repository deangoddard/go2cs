//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:10:38 UTC
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
    public static partial class ssagen_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct skipMask
        {
            // Value of the skipMask struct
            private readonly byte m_value;
            
            public skipMask(byte value) => m_value = value;

            // Enable implicit conversions between byte and skipMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator skipMask(byte value) => new skipMask(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(skipMask value) => value.m_value;
            
            // Enable comparisons between nil and skipMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(skipMask value, NilType nil) => value.Equals(default(skipMask));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(skipMask value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, skipMask value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, skipMask value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator skipMask(NilType nil) => default(skipMask);
        }
    }
}}}}