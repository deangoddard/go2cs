//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:27:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct symByName
        {
            // Value of the symByName struct
            private readonly slice<ref types.Sym> m_value;

            public symByName(slice<ref types.Sym> value) => m_value = value;

            // Enable implicit conversions between slice<ref types.Sym> and symByName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator symByName(slice<ref types.Sym> value) => new symByName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ref types.Sym>(symByName value) => value.m_value;
            
            // Enable comparisons between nil and symByName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(symByName value, NilType nil) => value.Equals(default(symByName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(symByName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, symByName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, symByName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator symByName(NilType nil) => default(symByName);
        }
    }
}}}}
