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
        public partial struct Systemreg
        {
            // Constructors
            public Systemreg(NilType _)
            {
                this.op0 = default;
                this.op1 = default;
                this.cn = default;
                this.cm = default;
                this.op2 = default;
            }

            public Systemreg(byte op0 = default, byte op1 = default, byte cn = default, byte cm = default, byte op2 = default)
            {
                this.op0 = op0;
                this.op1 = op1;
                this.cn = cn;
                this.cm = cm;
                this.op2 = op2;
            }

            // Enable comparisons between nil and Systemreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Systemreg value, NilType nil) => value.Equals(default(Systemreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Systemreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Systemreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Systemreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Systemreg(NilType nil) => default(Systemreg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Systemreg Systemreg_cast(dynamic value)
        {
            return new Systemreg(value.op0, value.op1, value.cn, value.cm, value.op2);
        }
    }
}}}}}}}