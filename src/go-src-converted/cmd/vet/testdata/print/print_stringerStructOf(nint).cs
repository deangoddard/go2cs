//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringer
        {
            // Value of the stringer struct
            private readonly nint m_value;
            
            public stringer(nint value) => m_value = value;

            // Enable implicit conversions between nint and stringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringer(nint value) => new stringer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(stringer value) => value.m_value;
            
            // Enable comparisons between nil and stringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringer value, NilType nil) => value.Equals(default(stringer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringer(NilType nil) => default(stringer);
        }
    }
}}}}
