//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:45:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct indexType
        {
            // Value of the indexType struct
            private readonly nint m_value;
            
            public indexType(nint value) => m_value = value;

            // Enable implicit conversions between nint and indexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indexType(nint value) => new indexType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(indexType value) => value.m_value;
            
            // Enable comparisons between nil and indexType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(indexType value, NilType nil) => value.Equals(default(indexType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(indexType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, indexType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, indexType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator indexType(NilType nil) => default(indexType);
        }
    }
}}}}}}
