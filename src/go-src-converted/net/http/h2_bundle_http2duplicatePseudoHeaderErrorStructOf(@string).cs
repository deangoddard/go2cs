//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:47 UTC
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
        private partial struct http2duplicatePseudoHeaderError
        {
            // Value of the http2duplicatePseudoHeaderError struct
            private readonly @string m_value;

            public http2duplicatePseudoHeaderError(@string value) => m_value = value;

            // Enable implicit conversions between @string and http2duplicatePseudoHeaderError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2duplicatePseudoHeaderError(@string value) => new http2duplicatePseudoHeaderError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(http2duplicatePseudoHeaderError value) => value.m_value;
            
            // Enable comparisons between nil and http2duplicatePseudoHeaderError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2duplicatePseudoHeaderError value, NilType nil) => value.Equals(default(http2duplicatePseudoHeaderError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2duplicatePseudoHeaderError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2duplicatePseudoHeaderError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2duplicatePseudoHeaderError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2duplicatePseudoHeaderError(NilType nil) => default(http2duplicatePseudoHeaderError);
        }
    }
}}
