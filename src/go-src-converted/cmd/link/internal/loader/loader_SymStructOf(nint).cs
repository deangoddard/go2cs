//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:20:34 UTC
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
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Sym
        {
            // Value of the Sym struct
            private readonly nint m_value;
            
            public Sym(nint value) => m_value = value;

            // Enable implicit conversions between nint and Sym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sym(nint value) => new Sym(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(Sym value) => value.m_value;
            
            // Enable comparisons between nil and Sym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Sym value, NilType nil) => value.Equals(default(Sym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Sym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Sym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Sym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Sym(NilType nil) => default(Sym);
        }
    }
}}}}
