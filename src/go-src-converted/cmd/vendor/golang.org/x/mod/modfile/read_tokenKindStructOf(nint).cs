//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:00 UTC
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
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tokenKind
        {
            // Value of the tokenKind struct
            private readonly nint m_value;
            
            public tokenKind(nint value) => m_value = value;

            // Enable implicit conversions between nint and tokenKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tokenKind(nint value) => new tokenKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(tokenKind value) => value.m_value;
            
            // Enable comparisons between nil and tokenKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tokenKind value, NilType nil) => value.Equals(default(tokenKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tokenKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tokenKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tokenKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tokenKind(NilType nil) => default(tokenKind);
        }
    }
}}}}}}