//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace os
{
    public static partial class user_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnknownGroupIdError
        {
            // Value of the UnknownGroupIdError struct
            private readonly @string m_value;

            public UnknownGroupIdError(@string value) => m_value = value;

            // Enable implicit conversions between @string and UnknownGroupIdError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnknownGroupIdError(@string value) => new UnknownGroupIdError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(UnknownGroupIdError value) => value.m_value;
            
            // Enable comparisons between nil and UnknownGroupIdError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnknownGroupIdError value, NilType nil) => value.Equals(default(UnknownGroupIdError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnknownGroupIdError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnknownGroupIdError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnknownGroupIdError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnknownGroupIdError(NilType nil) => default(UnknownGroupIdError);
        }
    }
}}
