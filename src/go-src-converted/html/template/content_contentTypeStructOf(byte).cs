//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:50 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct contentType
        {
            // Value of the contentType struct
            private readonly byte m_value;
            
            public contentType(byte value) => m_value = value;

            // Enable implicit conversions between byte and contentType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator contentType(byte value) => new contentType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(contentType value) => value.m_value;
            
            // Enable comparisons between nil and contentType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(contentType value, NilType nil) => value.Equals(default(contentType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(contentType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, contentType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, contentType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator contentType(NilType nil) => default(contentType);
        }
    }
}}
