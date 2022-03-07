//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

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
                this.R15 = default;
                this.R14 = default;
                this.R13 = default;
                this.R12 = default;
                this.Rbp = default;
                this.Rbx = default;
                this.R11 = default;
                this.R10 = default;
                this.R9 = default;
                this.R8 = default;
                this.Rax = default;
                this.Rcx = default;
                this.Rdx = default;
                this.Rsi = default;
                this.Rdi = default;
                this.Orig_rax = default;
                this.Rip = default;
                this.Cs = default;
                this.Eflags = default;
                this.Rsp = default;
                this.Ss = default;
                this.Fs_base = default;
                this.Gs_base = default;
                this.Ds = default;
                this.Es = default;
                this.Fs = default;
                this.Gs = default;
            }

            public PtraceRegs(ulong R15 = default, ulong R14 = default, ulong R13 = default, ulong R12 = default, ulong Rbp = default, ulong Rbx = default, ulong R11 = default, ulong R10 = default, ulong R9 = default, ulong R8 = default, ulong Rax = default, ulong Rcx = default, ulong Rdx = default, ulong Rsi = default, ulong Rdi = default, ulong Orig_rax = default, ulong Rip = default, ulong Cs = default, ulong Eflags = default, ulong Rsp = default, ulong Ss = default, ulong Fs_base = default, ulong Gs_base = default, ulong Ds = default, ulong Es = default, ulong Fs = default, ulong Gs = default)
            {
                this.R15 = R15;
                this.R14 = R14;
                this.R13 = R13;
                this.R12 = R12;
                this.Rbp = Rbp;
                this.Rbx = Rbx;
                this.R11 = R11;
                this.R10 = R10;
                this.R9 = R9;
                this.R8 = R8;
                this.Rax = Rax;
                this.Rcx = Rcx;
                this.Rdx = Rdx;
                this.Rsi = Rsi;
                this.Rdi = Rdi;
                this.Orig_rax = Orig_rax;
                this.Rip = Rip;
                this.Cs = Cs;
                this.Eflags = Eflags;
                this.Rsp = Rsp;
                this.Ss = Ss;
                this.Fs_base = Fs_base;
                this.Gs_base = Gs_base;
                this.Ds = Ds;
                this.Es = Es;
                this.Fs = Fs;
                this.Gs = Gs;
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
            return new PtraceRegs(value.R15, value.R14, value.R13, value.R12, value.Rbp, value.Rbx, value.R11, value.R10, value.R9, value.R8, value.Rax, value.Rcx, value.Rdx, value.Rsi, value.Rdi, value.Orig_rax, value.Rip, value.Cs, value.Eflags, value.Rsp, value.Ss, value.Fs_base, value.Gs_base, value.Ds, value.Es, value.Fs, value.Gs);
        }
    }
}