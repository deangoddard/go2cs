//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:53:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class aes_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct code
        {
            // Value of the code struct
            private readonly long m_value;

            public code(long value) => m_value = value;

            // Enable implicit conversions between long and code struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator code(long value) => new code(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(code value) => value.m_value;
            
            // Enable comparisons between nil and code struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(code value, NilType nil) => value.Equals(default(code));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(code value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, code value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, code value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator code(NilType nil) => default(code);
        }
    }
}}
