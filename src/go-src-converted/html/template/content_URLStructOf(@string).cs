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
        public partial struct URL
        {
            // Value of the URL struct
            private readonly @string m_value;
            
            public URL(@string value) => m_value = value;

            // Enable implicit conversions between @string and URL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URL(@string value) => new URL(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(URL value) => value.m_value;
            
            // Enable comparisons between nil and URL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(URL value, NilType nil) => value.Equals(default(URL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(URL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, URL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, URL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URL(NilType nil) => default(URL);
        }
    }
}}
