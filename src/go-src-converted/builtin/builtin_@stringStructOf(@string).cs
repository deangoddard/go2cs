//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class builtin_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct @string
        {
            // Value of the @string struct
            private readonly @string m_value;
            
            public @string(@string value) => m_value = value;

            // Enable implicit conversions between @string and @string struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(@string value) => new @string(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(@string value) => value.m_value;
            
            // Enable comparisons between nil and @string struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(@string value, NilType nil) => value.Equals(default(@string));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(@string value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, @string value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, @string value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(NilType nil) => default(@string);
        }
    }
}
