//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:30:09 UTC
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
        private partial struct mapnames
        {
            // Value of the mapnames struct
            private readonly array<@string> m_value;

            public mapnames(array<@string> value) => m_value = value;

            // Enable implicit conversions between array<@string> and mapnames struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mapnames(array<@string> value) => new mapnames(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<@string>(mapnames value) => value.m_value;
            
            // Enable comparisons between nil and mapnames struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mapnames value, NilType nil) => value.Equals(default(mapnames));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mapnames value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mapnames value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mapnames value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mapnames(NilType nil) => default(mapnames);
        }
    }
}}}}
