//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:08 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct http2ConnectionError
        {
            // Value of the http2ConnectionError struct
            private readonly http2ErrCode m_value;
            
            public http2ConnectionError(http2ErrCode value) => m_value = value;

            // Enable implicit conversions between http2ErrCode and http2ConnectionError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2ConnectionError(http2ErrCode value) => new http2ConnectionError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2ErrCode(http2ConnectionError value) => value.m_value;
            
            // Enable comparisons between nil and http2ConnectionError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2ConnectionError value, NilType nil) => value.Equals(default(http2ConnectionError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2ConnectionError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2ConnectionError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2ConnectionError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2ConnectionError(NilType nil) => default(http2ConnectionError);
        }
    }
}}
