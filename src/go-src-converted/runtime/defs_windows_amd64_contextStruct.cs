//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:53 UTC
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
        private partial struct context
        {
            // Constructors
            public context(NilType _)
            {
                this.p1home = default;
                this.p2home = default;
                this.p3home = default;
                this.p4home = default;
                this.p5home = default;
                this.p6home = default;
                this.contextflags = default;
                this.mxcsr = default;
                this.segcs = default;
                this.segds = default;
                this.seges = default;
                this.segfs = default;
                this.seggs = default;
                this.segss = default;
                this.eflags = default;
                this.dr0 = default;
                this.dr1 = default;
                this.dr2 = default;
                this.dr3 = default;
                this.dr6 = default;
                this.dr7 = default;
                this.rax = default;
                this.rcx = default;
                this.rdx = default;
                this.rbx = default;
                this.rsp = default;
                this.rbp = default;
                this.rsi = default;
                this.rdi = default;
                this.r8 = default;
                this.r9 = default;
                this.r10 = default;
                this.r11 = default;
                this.r12 = default;
                this.r13 = default;
                this.r14 = default;
                this.r15 = default;
                this.rip = default;
                this.anon0 = default;
                this.vectorregister = default;
                this.vectorcontrol = default;
                this.debugcontrol = default;
                this.lastbranchtorip = default;
                this.lastbranchfromrip = default;
                this.lastexceptiontorip = default;
                this.lastexceptionfromrip = default;
            }

            public context(ulong p1home = default, ulong p2home = default, ulong p3home = default, ulong p4home = default, ulong p5home = default, ulong p6home = default, uint contextflags = default, uint mxcsr = default, ushort segcs = default, ushort segds = default, ushort seges = default, ushort segfs = default, ushort seggs = default, ushort segss = default, uint eflags = default, ulong dr0 = default, ulong dr1 = default, ulong dr2 = default, ulong dr3 = default, ulong dr6 = default, ulong dr7 = default, ulong rax = default, ulong rcx = default, ulong rdx = default, ulong rbx = default, ulong rsp = default, ulong rbp = default, ulong rsi = default, ulong rdi = default, ulong r8 = default, ulong r9 = default, ulong r10 = default, ulong r11 = default, ulong r12 = default, ulong r13 = default, ulong r14 = default, ulong r15 = default, ulong rip = default, array<byte> anon0 = default, array<m128a> vectorregister = default, ulong vectorcontrol = default, ulong debugcontrol = default, ulong lastbranchtorip = default, ulong lastbranchfromrip = default, ulong lastexceptiontorip = default, ulong lastexceptionfromrip = default)
            {
                this.p1home = p1home;
                this.p2home = p2home;
                this.p3home = p3home;
                this.p4home = p4home;
                this.p5home = p5home;
                this.p6home = p6home;
                this.contextflags = contextflags;
                this.mxcsr = mxcsr;
                this.segcs = segcs;
                this.segds = segds;
                this.seges = seges;
                this.segfs = segfs;
                this.seggs = seggs;
                this.segss = segss;
                this.eflags = eflags;
                this.dr0 = dr0;
                this.dr1 = dr1;
                this.dr2 = dr2;
                this.dr3 = dr3;
                this.dr6 = dr6;
                this.dr7 = dr7;
                this.rax = rax;
                this.rcx = rcx;
                this.rdx = rdx;
                this.rbx = rbx;
                this.rsp = rsp;
                this.rbp = rbp;
                this.rsi = rsi;
                this.rdi = rdi;
                this.r8 = r8;
                this.r9 = r9;
                this.r10 = r10;
                this.r11 = r11;
                this.r12 = r12;
                this.r13 = r13;
                this.r14 = r14;
                this.r15 = r15;
                this.rip = rip;
                this.anon0 = anon0;
                this.vectorregister = vectorregister;
                this.vectorcontrol = vectorcontrol;
                this.debugcontrol = debugcontrol;
                this.lastbranchtorip = lastbranchtorip;
                this.lastbranchfromrip = lastbranchfromrip;
                this.lastexceptiontorip = lastexceptiontorip;
                this.lastexceptionfromrip = lastexceptionfromrip;
            }

            // Enable comparisons between nil and context struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(context value, NilType nil) => value.Equals(default(context));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(context value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, context value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, context value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator context(NilType nil) => default(context);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static context context_cast(dynamic value)
        {
            return new context(value.p1home, value.p2home, value.p3home, value.p4home, value.p5home, value.p6home, value.contextflags, value.mxcsr, value.segcs, value.segds, value.seges, value.segfs, value.seggs, value.segss, value.eflags, value.dr0, value.dr1, value.dr2, value.dr3, value.dr6, value.dr7, value.rax, value.rcx, value.rdx, value.rbx, value.rsp, value.rbp, value.rsi, value.rdi, value.r8, value.r9, value.r10, value.r11, value.r12, value.r13, value.r14, value.r15, value.rip, value.anon0, value.vectorregister, value.vectorcontrol, value.debugcontrol, value.lastbranchtorip, value.lastbranchfromrip, value.lastexceptiontorip, value.lastexceptionfromrip);
        }
    }
}