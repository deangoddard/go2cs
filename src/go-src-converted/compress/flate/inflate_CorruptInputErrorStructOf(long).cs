//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:15:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CorruptInputError
        {
            // Value of the CorruptInputError struct
            private readonly long m_value;
            
            public CorruptInputError(long value) => m_value = value;

            // Enable implicit conversions between long and CorruptInputError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CorruptInputError(long value) => new CorruptInputError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(CorruptInputError value) => value.m_value;
            
            // Enable comparisons between nil and CorruptInputError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CorruptInputError value, NilType nil) => value.Equals(default(CorruptInputError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CorruptInputError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CorruptInputError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CorruptInputError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CorruptInputError(NilType nil) => default(CorruptInputError);
        }
    }
}}
