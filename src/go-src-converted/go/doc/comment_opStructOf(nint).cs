//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class doc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct op
        {
            // Value of the op struct
            private readonly nint m_value;
            
            public op(nint value) => m_value = value;

            // Enable implicit conversions between nint and op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator op(nint value) => new op(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(op value) => value.m_value;
            
            // Enable comparisons between nil and op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(op value, NilType nil) => value.Equals(default(op));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(op value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, op value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, op value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator op(NilType nil) => default(op);
        }
    }
}}