//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:34:36 UTC
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SymbolType
        {
            // Value of the SymbolType struct
            private readonly sbyte m_value;
            
            public SymbolType(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and SymbolType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymbolType(sbyte value) => new SymbolType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(SymbolType value) => value.m_value;
            
            // Enable comparisons between nil and SymbolType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SymbolType value, NilType nil) => value.Equals(default(SymbolType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SymbolType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SymbolType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SymbolType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymbolType(NilType nil) => default(SymbolType);
        }
    }
}}}}
