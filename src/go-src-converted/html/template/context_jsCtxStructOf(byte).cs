//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace html
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct jsCtx
        {
            // Value of the jsCtx struct
            private readonly byte m_value;
            
            public jsCtx(byte value) => m_value = value;

            // Enable implicit conversions between byte and jsCtx struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator jsCtx(byte value) => new jsCtx(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(jsCtx value) => value.m_value;
            
            // Enable comparisons between nil and jsCtx struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(jsCtx value, NilType nil) => value.Equals(default(jsCtx));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(jsCtx value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, jsCtx value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, jsCtx value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator jsCtx(NilType nil) => default(jsCtx);
        }
    }
}}
