//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Imm
        {
            // Value of the Imm struct
            private readonly int m_value;

            public Imm(int value) => m_value = value;

            // Enable implicit conversions between int and Imm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Imm(int value) => new Imm(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(Imm value) => value.m_value;
            
            // Enable comparisons between nil and Imm struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Imm value, NilType nil) => value.Equals(default(Imm));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Imm value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Imm value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Imm value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Imm(NilType nil) => default(Imm);
        }
    }
}}}}}}}
