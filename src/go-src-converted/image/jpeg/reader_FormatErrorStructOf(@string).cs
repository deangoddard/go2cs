//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FormatError
        {
            // Value of the FormatError struct
            private readonly @string m_value;

            public FormatError(@string value) => m_value = value;

            // Enable implicit conversions between @string and FormatError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FormatError(@string value) => new FormatError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(FormatError value) => value.m_value;
            
            // Enable comparisons between nil and FormatError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FormatError value, NilType nil) => value.Equals(default(FormatError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FormatError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FormatError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FormatError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FormatError(NilType nil) => default(FormatError);
        }
    }
}}
