//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:33:28 UTC
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
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct LoaderSym
        {
            // Value of the LoaderSym struct
            private readonly nint m_value;
            
            public LoaderSym(nint value) => m_value = value;

            // Enable implicit conversions between nint and LoaderSym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LoaderSym(nint value) => new LoaderSym(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(LoaderSym value) => value.m_value;
            
            // Enable comparisons between nil and LoaderSym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LoaderSym value, NilType nil) => value.Equals(default(LoaderSym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LoaderSym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LoaderSym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LoaderSym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LoaderSym(NilType nil) => default(LoaderSym);
        }
    }
}}}}
