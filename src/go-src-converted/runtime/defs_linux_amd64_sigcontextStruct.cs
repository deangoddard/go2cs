//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sigcontext
        {
            // Constructors
            public sigcontext(NilType _)
            {
                this.r8 = default;
                this.r9 = default;
                this.r10 = default;
                this.r11 = default;
                this.r12 = default;
                this.r13 = default;
                this.r14 = default;
                this.r15 = default;
                this.rdi = default;
                this.rsi = default;
                this.rbp = default;
                this.rbx = default;
                this.rdx = default;
                this.rax = default;
                this.rcx = default;
                this.rsp = default;
                this.rip = default;
                this.eflags = default;
                this.cs = default;
                this.gs = default;
                this.fs = default;
                this.__pad0 = default;
                this.err = default;
                this.trapno = default;
                this.oldmask = default;
                this.cr2 = default;
                this.fpstate = default;
                this.__reserved1 = default;
            }

            public sigcontext(ulong r8 = default, ulong r9 = default, ulong r10 = default, ulong r11 = default, ulong r12 = default, ulong r13 = default, ulong r14 = default, ulong r15 = default, ulong rdi = default, ulong rsi = default, ulong rbp = default, ulong rbx = default, ulong rdx = default, ulong rax = default, ulong rcx = default, ulong rsp = default, ulong rip = default, ulong eflags = default, ushort cs = default, ushort gs = default, ushort fs = default, ushort __pad0 = default, ulong err = default, ulong trapno = default, ulong oldmask = default, ulong cr2 = default, ref ptr<fpstate1> fpstate = default, array<ulong> __reserved1 = default)
            {
                this.r8 = r8;
                this.r9 = r9;
                this.r10 = r10;
                this.r11 = r11;
                this.r12 = r12;
                this.r13 = r13;
                this.r14 = r14;
                this.r15 = r15;
                this.rdi = rdi;
                this.rsi = rsi;
                this.rbp = rbp;
                this.rbx = rbx;
                this.rdx = rdx;
                this.rax = rax;
                this.rcx = rcx;
                this.rsp = rsp;
                this.rip = rip;
                this.eflags = eflags;
                this.cs = cs;
                this.gs = gs;
                this.fs = fs;
                this.__pad0 = __pad0;
                this.err = err;
                this.trapno = trapno;
                this.oldmask = oldmask;
                this.cr2 = cr2;
                this.fpstate = fpstate;
                this.__reserved1 = __reserved1;
            }

            // Enable comparisons between nil and sigcontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigcontext value, NilType nil) => value.Equals(default(sigcontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigcontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigcontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigcontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigcontext(NilType nil) => default(sigcontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sigcontext sigcontext_cast(dynamic value)
        {
            return new sigcontext(value.r8, value.r9, value.r10, value.r11, value.r12, value.r13, value.r14, value.r15, value.rdi, value.rsi, value.rbp, value.rbx, value.rdx, value.rax, value.rcx, value.rsp, value.rip, value.eflags, value.cs, value.gs, value.fs, value.__pad0, value.err, value.trapno, value.oldmask, value.cr2, ref value.fpstate, value.__reserved1);
        }
    }
}