//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:50:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byName
        {
            // Value of the byName struct
            private readonly slice<ptr<sym.Symbol>> m_value;

            public byName(slice<ptr<sym.Symbol>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<sym.Symbol>> and byName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byName(slice<ptr<sym.Symbol>> value) => new byName(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<sym.Symbol>>(byName value) => value.m_value;
            
            // Enable comparisons between nil and byName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byName value, NilType nil) => value.Equals(default(byName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byName(NilType nil) => default(byName);
        }
    }
}}}}
