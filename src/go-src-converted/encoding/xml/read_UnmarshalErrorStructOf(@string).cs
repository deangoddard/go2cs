//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnmarshalError
        {
            // Value of the UnmarshalError struct
            private readonly @string m_value;

            public UnmarshalError(@string value) => m_value = value;

            // Enable implicit conversions between @string and UnmarshalError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnmarshalError(@string value) => new UnmarshalError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(UnmarshalError value) => value.m_value;
            
            // Enable comparisons between nil and UnmarshalError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnmarshalError value, NilType nil) => value.Equals(default(UnmarshalError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnmarshalError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnmarshalError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnmarshalError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnmarshalError(NilType nil) => default(UnmarshalError);
        }
    }
}}
