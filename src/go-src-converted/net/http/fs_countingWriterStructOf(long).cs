//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:36:32 UTC
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
        private partial struct countingWriter
        {
            // Value of the countingWriter struct
            private readonly long m_value;
            
            public countingWriter(long value) => m_value = value;

            // Enable implicit conversions between long and countingWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator countingWriter(long value) => new countingWriter(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(countingWriter value) => value.m_value;
            
            // Enable comparisons between nil and countingWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(countingWriter value, NilType nil) => value.Equals(default(countingWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(countingWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, countingWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, countingWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator countingWriter(NilType nil) => default(countingWriter);
        }
    }
}}
