//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:31 UTC
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
namespace compile {
namespace @internal
{
    public static partial class abi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RegIndex
        {
            // Value of the RegIndex struct
            private readonly byte m_value;
            
            public RegIndex(byte value) => m_value = value;

            // Enable implicit conversions between byte and RegIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegIndex(byte value) => new RegIndex(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(RegIndex value) => value.m_value;
            
            // Enable comparisons between nil and RegIndex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RegIndex value, NilType nil) => value.Equals(default(RegIndex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RegIndex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RegIndex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RegIndex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegIndex(NilType nil) => default(RegIndex);
        }
    }
}}}}
