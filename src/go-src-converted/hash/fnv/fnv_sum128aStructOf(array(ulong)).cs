//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace hash
{
    public static partial class fnv_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sum128a
        {
            // Value of the sum128a struct
            private readonly array<ulong> m_value;

            public sum128a(array<ulong> value) => m_value = value;

            // Enable implicit conversions between array<ulong> and sum128a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum128a(array<ulong> value) => new sum128a(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<ulong>(sum128a value) => value.m_value;
            
            // Enable comparisons between nil and sum128a struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sum128a value, NilType nil) => value.Equals(default(sum128a));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sum128a value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sum128a value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sum128a value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sum128a(NilType nil) => default(sum128a);
        }
    }
}}
