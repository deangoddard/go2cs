//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:25 UTC
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
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Reg
        {
            // Value of the Reg struct
            private readonly byte m_value;

            public Reg(byte value) => m_value = value;

            // Enable implicit conversions between byte and Reg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reg(byte value) => new Reg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Reg value) => value.m_value;
            
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
