//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:02:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RelocByOff
        {
            // Value of the RelocByOff struct
            private readonly slice<Reloc> m_value;

            public RelocByOff(slice<Reloc> value) => m_value = value;

            // Enable implicit conversions between slice<Reloc> and RelocByOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RelocByOff(slice<Reloc> value) => new RelocByOff(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Reloc>(RelocByOff value) => value.m_value;
            
            // Enable comparisons between nil and RelocByOff struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RelocByOff value, NilType nil) => value.Equals(default(RelocByOff));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RelocByOff value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RelocByOff value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RelocByOff value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RelocByOff(NilType nil) => default(RelocByOff);
        }
    }
}}}}
