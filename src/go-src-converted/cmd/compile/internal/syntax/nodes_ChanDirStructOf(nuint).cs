//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:10 UTC
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
        public partial struct ChanDir
        {
            // Value of the ChanDir struct
            private readonly nuint m_value;
            
            public ChanDir(nuint value) => m_value = value;

            // Enable implicit conversions between nuint and ChanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChanDir(nuint value) => new ChanDir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nuint(ChanDir value) => value.m_value;
            
            // Enable comparisons between nil and ChanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ChanDir value, NilType nil) => value.Equals(default(ChanDir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ChanDir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ChanDir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ChanDir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChanDir(NilType nil) => default(ChanDir);
        }
    }
}}}}
