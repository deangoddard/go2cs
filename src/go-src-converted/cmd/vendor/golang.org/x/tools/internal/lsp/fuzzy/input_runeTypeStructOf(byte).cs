//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:14 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace lsp
{
    public static partial class fuzzy_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct runeType
        {
            // Value of the runeType struct
            private readonly byte m_value;
            
            public runeType(byte value) => m_value = value;

            // Enable implicit conversions between byte and runeType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runeType(byte value) => new runeType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(runeType value) => value.m_value;
            
            // Enable comparisons between nil and runeType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(runeType value, NilType nil) => value.Equals(default(runeType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(runeType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, runeType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, runeType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator runeType(NilType nil) => default(runeType);
        }
    }
}}}}}}}}
