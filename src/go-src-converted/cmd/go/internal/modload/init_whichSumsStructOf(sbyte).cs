//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:18:10 UTC
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
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct whichSums
        {
            // Value of the whichSums struct
            private readonly sbyte m_value;
            
            public whichSums(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and whichSums struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator whichSums(sbyte value) => new whichSums(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(whichSums value) => value.m_value;
            
            // Enable comparisons between nil and whichSums struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(whichSums value, NilType nil) => value.Equals(default(whichSums));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(whichSums value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, whichSums value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, whichSums value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator whichSums(NilType nil) => default(whichSums);
        }
    }
}}}}