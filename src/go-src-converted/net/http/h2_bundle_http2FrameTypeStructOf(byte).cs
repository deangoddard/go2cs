//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:21:57 UTC
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
        private partial struct http2FrameType
        {
            // Value of the http2FrameType struct
            private readonly byte m_value;
            
            public http2FrameType(byte value) => m_value = value;

            // Enable implicit conversions between byte and http2FrameType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2FrameType(byte value) => new http2FrameType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(http2FrameType value) => value.m_value;
            
            // Enable comparisons between nil and http2FrameType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2FrameType value, NilType nil) => value.Equals(default(http2FrameType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2FrameType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2FrameType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2FrameType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2FrameType(NilType nil) => default(http2FrameType);
        }
    }
}}
