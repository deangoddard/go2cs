//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class mail_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct charsetError
        {
            // Value of the charsetError struct
            private readonly @string m_value;

            public charsetError(@string value) => m_value = value;

            // Enable implicit conversions between @string and charsetError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator charsetError(@string value) => new charsetError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(charsetError value) => value.m_value;
            
            // Enable comparisons between nil and charsetError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(charsetError value, NilType nil) => value.Equals(default(charsetError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(charsetError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, charsetError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, charsetError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator charsetError(NilType nil) => default(charsetError);
        }
    }
}}
