//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:49 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct scoreVal
        {
            // Value of the scoreVal struct
            private readonly nint m_value;
            
            public scoreVal(nint value) => m_value = value;

            // Enable implicit conversions between nint and scoreVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scoreVal(nint value) => new scoreVal(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(scoreVal value) => value.m_value;
            
            // Enable comparisons between nil and scoreVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(scoreVal value, NilType nil) => value.Equals(default(scoreVal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(scoreVal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, scoreVal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, scoreVal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scoreVal(NilType nil) => default(scoreVal);
        }
    }
}}}}}}}}
