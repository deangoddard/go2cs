//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct RegExtshiftAmount
        {
            // Constructors
            public RegExtshiftAmount(NilType _)
            {
                this.reg = default;
                this.extShift = default;
                this.amount = default;
                this.show_zero = default;
            }

            public RegExtshiftAmount(Reg reg = default, ExtShift extShift = default, byte amount = default, bool show_zero = default)
            {
                this.reg = reg;
                this.extShift = extShift;
                this.amount = amount;
                this.show_zero = show_zero;
            }

            // Enable comparisons between nil and RegExtshiftAmount struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RegExtshiftAmount value, NilType nil) => value.Equals(default(RegExtshiftAmount));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RegExtshiftAmount value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RegExtshiftAmount value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RegExtshiftAmount value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegExtshiftAmount(NilType nil) => default(RegExtshiftAmount);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RegExtshiftAmount RegExtshiftAmount_cast(dynamic value)
        {
            return new RegExtshiftAmount(value.reg, value.extShift, value.amount, value.show_zero);
        }
    }
}}}}}}}