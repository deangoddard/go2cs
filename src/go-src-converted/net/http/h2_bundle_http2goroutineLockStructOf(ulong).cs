//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2goroutineLock
        {
            // Value of the http2goroutineLock struct
            private readonly ulong m_value;

            public http2goroutineLock(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and http2goroutineLock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2goroutineLock(ulong value) => new http2goroutineLock(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(http2goroutineLock value) => value.m_value;
            
            // Enable comparisons between nil and http2goroutineLock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2goroutineLock value, NilType nil) => value.Equals(default(http2goroutineLock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2goroutineLock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2goroutineLock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2goroutineLock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2goroutineLock(NilType nil) => default(http2goroutineLock);
        }
    }
}}
