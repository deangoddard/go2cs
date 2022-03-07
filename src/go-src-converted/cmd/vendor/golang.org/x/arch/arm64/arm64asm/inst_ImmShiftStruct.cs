//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:24:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
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
        public partial struct ImmShift
        {
            // Constructors
            public ImmShift(NilType _)
            {
                this.imm = default;
                this.shift = default;
            }

            public ImmShift(ushort imm = default, byte shift = default)
            {
                this.imm = imm;
                this.shift = shift;
            }

            // Enable comparisons between nil and ImmShift struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImmShift value, NilType nil) => value.Equals(default(ImmShift));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImmShift value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImmShift value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImmShift value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImmShift(NilType nil) => default(ImmShift);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ImmShift ImmShift_cast(dynamic value)
        {
            return new ImmShift(value.imm, value.shift);
        }
    }
}}}}}}}