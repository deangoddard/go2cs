//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:07:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

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
        public partial struct Reg
        {
            // Value of the Reg struct
            private readonly ushort m_value;

            public Reg(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and Reg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reg(ushort value) => new Reg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(Reg value) => value.m_value;
            
            // Enable comparisons between nil and Reg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reg value, NilType nil) => value.Equals(default(Reg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reg(NilType nil) => default(Reg);
        }
    }
}}}}}}}
