//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:54:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct MergeMode
        {
            // Value of the MergeMode struct
            private readonly nuint m_value;
            
            public MergeMode(nuint value) => m_value = value;

            // Enable implicit conversions between nuint and MergeMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MergeMode(nuint value) => new MergeMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nuint(MergeMode value) => value.m_value;
            
            // Enable comparisons between nil and MergeMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MergeMode value, NilType nil) => value.Equals(default(MergeMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MergeMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MergeMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MergeMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MergeMode(NilType nil) => default(MergeMode);
        }
    }
}}
