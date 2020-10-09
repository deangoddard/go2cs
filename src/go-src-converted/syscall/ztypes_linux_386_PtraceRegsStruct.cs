//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:25 UTC
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
                this.Ebx = default;
                this.Ecx = default;
                this.Edx = default;
                this.Esi = default;
                this.Edi = default;
                this.Ebp = default;
                this.Eax = default;
                this.Xds = default;
                this.Xes = default;
                this.Xfs = default;
                this.Xgs = default;
                this.Orig_eax = default;
                this.Eip = default;
                this.Xcs = default;
                this.Eflags = default;
                this.Esp = default;
                this.Xss = default;
            }

            public PtraceRegs(int Ebx = default, int Ecx = default, int Edx = default, int Esi = default, int Edi = default, int Ebp = default, int Eax = default, int Xds = default, int Xes = default, int Xfs = default, int Xgs = default, int Orig_eax = default, int Eip = default, int Xcs = default, int Eflags = default, int Esp = default, int Xss = default)
            {
                this.Ebx = Ebx;
                this.Ecx = Ecx;
                this.Edx = Edx;
                this.Esi = Esi;
                this.Edi = Edi;
                this.Ebp = Ebp;
                this.Eax = Eax;
                this.Xds = Xds;
                this.Xes = Xes;
                this.Xfs = Xfs;
                this.Xgs = Xgs;
                this.Orig_eax = Orig_eax;
                this.Eip = Eip;
                this.Xcs = Xcs;
                this.Eflags = Eflags;
                this.Esp = Esp;
                this.Xss = Xss;
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
            return new PtraceRegs(value.Ebx, value.Ecx, value.Edx, value.Esi, value.Edi, value.Ebp, value.Eax, value.Xds, value.Xes, value.Xfs, value.Xgs, value.Orig_eax, value.Eip, value.Xcs, value.Eflags, value.Esp, value.Xss);
        }
    }
}