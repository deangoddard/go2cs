//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:11 UTC
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
        private partial struct socksReply
        {
            // Value of the socksReply struct
            private readonly nint m_value;
            
            public socksReply(nint value) => m_value = value;

            // Enable implicit conversions between nint and socksReply struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksReply(nint value) => new socksReply(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(socksReply value) => value.m_value;
            
            // Enable comparisons between nil and socksReply struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(socksReply value, NilType nil) => value.Equals(default(socksReply));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(socksReply value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, socksReply value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, socksReply value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksReply(NilType nil) => default(socksReply);
        }
    }
}}