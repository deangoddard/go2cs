//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:46 UTC
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
namespace arm64
{
    public static partial class arm64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RegSP
        {
            // Value of the RegSP struct
            private readonly Reg m_value;

            public RegSP(Reg value) => m_value = value;

            // Enable implicit conversions between Reg and RegSP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegSP(Reg value) => new RegSP(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reg(RegSP value) => value.m_value;
            
            // Enable comparisons between nil and RegSP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RegSP value, NilType nil) => value.Equals(default(RegSP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RegSP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RegSP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RegSP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegSP(NilType nil) => default(RegSP);
        }
    }
}}}}}}}
