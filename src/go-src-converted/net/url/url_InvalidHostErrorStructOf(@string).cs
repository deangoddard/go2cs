//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:17:04 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InvalidHostError
        {
            // Value of the InvalidHostError struct
            private readonly @string m_value;
            
            public InvalidHostError(@string value) => m_value = value;

            // Enable implicit conversions between @string and InvalidHostError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidHostError(@string value) => new InvalidHostError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(InvalidHostError value) => value.m_value;
            
            // Enable comparisons between nil and InvalidHostError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InvalidHostError value, NilType nil) => value.Equals(default(InvalidHostError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InvalidHostError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InvalidHostError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InvalidHostError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InvalidHostError(NilType nil) => default(InvalidHostError);
        }
    }
}}
