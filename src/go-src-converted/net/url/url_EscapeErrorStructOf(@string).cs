//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:30:25 UTC
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
    public static partial class url_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct EscapeError
        {
            // Value of the EscapeError struct
            private readonly @string m_value;
            
            public EscapeError(@string value) => m_value = value;

            // Enable implicit conversions between @string and EscapeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EscapeError(@string value) => new EscapeError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(EscapeError value) => value.m_value;
            
            // Enable comparisons between nil and EscapeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EscapeError value, NilType nil) => value.Equals(default(EscapeError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EscapeError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EscapeError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EscapeError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EscapeError(NilType nil) => default(EscapeError);
        }
    }
}}
