//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:36 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Token
        {
            // Value of the Token struct
            private readonly Handle m_value;
            
            public Token(Handle value) => m_value = value;

            // Enable implicit conversions between Handle and Token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Token(Handle value) => new Token(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Handle(Token value) => value.m_value;
            
            // Enable comparisons between nil and Token struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Token value, NilType nil) => value.Equals(default(Token));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Token value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Token value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Token value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Token(NilType nil) => default(Token);
        }
    }
}}}}}}
