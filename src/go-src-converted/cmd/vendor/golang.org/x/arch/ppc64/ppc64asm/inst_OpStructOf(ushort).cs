//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:38:20 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Op
        {
            // Value of the Op struct
            private readonly ushort m_value;
            
            public Op(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and Op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(ushort value) => new Op(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(Op value) => value.m_value;
            
            // Enable comparisons between nil and Op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Op value, NilType nil) => value.Equals(default(Op));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Op value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Op value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Op value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Op(NilType nil) => default(Op);
        }
    }
}}}}}}}
