//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PtraceRegs
        {
            // Constructors
            public PtraceRegs(NilType _)
            {
                this.Psw = default;
                this.Gprs = default;
                this.Acrs = default;
                this.Orig_gpr2 = default;
                this.Fp_regs = default;
                this.Per_info = default;
                this.Ieee_instruction_pointer = default;
            }

            public PtraceRegs(PtracePsw Psw = default, array<ulong> Gprs = default, array<uint> Acrs = default, ulong Orig_gpr2 = default, PtraceFpregs Fp_regs = default, PtracePer Per_info = default, ulong Ieee_instruction_pointer = default)
            {
                this.Psw = Psw;
                this.Gprs = Gprs;
                this.Acrs = Acrs;
                this.Orig_gpr2 = Orig_gpr2;
                this.Fp_regs = Fp_regs;
                this.Per_info = Per_info;
                this.Ieee_instruction_pointer = Ieee_instruction_pointer;
            }

            // Enable comparisons between nil and PtraceRegs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PtraceRegs value, NilType nil) => value.Equals(default(PtraceRegs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PtraceRegs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PtraceRegs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PtraceRegs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PtraceRegs(NilType nil) => default(PtraceRegs);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PtraceRegs PtraceRegs_cast(dynamic value)
        {
            return new PtraceRegs(value.Psw, value.Gprs, value.Acrs, value.Orig_gpr2, value.Fp_regs, value.Per_info, value.Ieee_instruction_pointer);
        }
    }
}