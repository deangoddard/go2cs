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
        private partial struct http2ErrCode
        {
            // Value of the http2ErrCode struct
            private readonly uint m_value;
            
            public http2ErrCode(uint value) => m_value = value;

            // Enable implicit conversions between uint and http2ErrCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2ErrCode(uint value) => new http2ErrCode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(http2ErrCode value) => value.m_value;
            
            // Enable comparisons between nil and http2ErrCode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2ErrCode value, NilType nil) => value.Equals(default(http2ErrCode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2ErrCode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2ErrCode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2ErrCode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2ErrCode(NilType nil) => default(http2ErrCode);
        }
    }
}}
