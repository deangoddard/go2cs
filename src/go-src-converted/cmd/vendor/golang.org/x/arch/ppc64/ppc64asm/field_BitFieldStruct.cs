//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:38:18 UTC
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
namespace ppc64
{
    public static partial class ppc64asm_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct BitField
        {
            // Constructors
            public BitField(NilType _)
            {
                this.Offs = default;
                this.Bits = default;
                this.Word = default;
            }

            public BitField(byte Offs = default, byte Bits = default, byte Word = default)
            {
                this.Offs = Offs;
                this.Bits = Bits;
                this.Word = Word;
            }

            // Enable comparisons between nil and BitField struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BitField value, NilType nil) => value.Equals(default(BitField));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BitField value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BitField value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BitField value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BitField(NilType nil) => default(BitField);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static BitField BitField_cast(dynamic value)
        {
            return new BitField(value.Offs, value.Bits, value.Word);
        }
    }
}}}}}}}