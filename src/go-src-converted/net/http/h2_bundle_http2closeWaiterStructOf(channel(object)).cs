//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2closeWaiter
        {
            // Value of the http2closeWaiter struct
            private readonly channel<object> m_value;

            public http2closeWaiter(channel<object> value) => m_value = value;

            // Enable implicit conversions between channel<object> and http2closeWaiter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2closeWaiter(channel<object> value) => new http2closeWaiter(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator channel<object>(http2closeWaiter value) => value.m_value;
            
            // Enable comparisons between nil and http2closeWaiter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2closeWaiter value, NilType nil) => value.Equals(default(http2closeWaiter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2closeWaiter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2closeWaiter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2closeWaiter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2closeWaiter(NilType nil) => default(http2closeWaiter);
        }
    }
}}
