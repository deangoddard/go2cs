//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:38 UTC
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
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ctrlSymbol
        {
            // Value of the ctrlSymbol struct
            private readonly nint m_value;
            
            public ctrlSymbol(nint value) => m_value = value;

            // Enable implicit conversions between nint and ctrlSymbol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ctrlSymbol(nint value) => new ctrlSymbol(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(ctrlSymbol value) => value.m_value;
            
            // Enable comparisons between nil and ctrlSymbol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ctrlSymbol value, NilType nil) => value.Equals(default(ctrlSymbol));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ctrlSymbol value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ctrlSymbol value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ctrlSymbol value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ctrlSymbol(NilType nil) => default(ctrlSymbol);
        }
    }
}}}}