//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:31 UTC
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
                this.Gpr = default;
                this.Nip = default;
                this.Msr = default;
                this.Orig_gpr3 = default;
                this.Ctr = default;
                this.Link = default;
                this.Xer = default;
                this.Ccr = default;
                this.Softe = default;
                this.Trap = default;
                this.Dar = default;
                this.Dsisr = default;
                this.Result = default;
            }

            public PtraceRegs(array<ulong> Gpr = default, ulong Nip = default, ulong Msr = default, ulong Orig_gpr3 = default, ulong Ctr = default, ulong Link = default, ulong Xer = default, ulong Ccr = default, ulong Softe = default, ulong Trap = default, ulong Dar = default, ulong Dsisr = default, ulong Result = default)
            {
                this.Gpr = Gpr;
                this.Nip = Nip;
                this.Msr = Msr;
                this.Orig_gpr3 = Orig_gpr3;
                this.Ctr = Ctr;
                this.Link = Link;
                this.Xer = Xer;
                this.Ccr = Ccr;
                this.Softe = Softe;
                this.Trap = Trap;
                this.Dar = Dar;
                this.Dsisr = Dsisr;
                this.Result = Result;
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
            return new PtraceRegs(value.Gpr, value.Nip, value.Msr, value.Orig_gpr3, value.Ctr, value.Link, value.Xer, value.Ccr, value.Softe, value.Trap, value.Dar, value.Dsisr, value.Result);
        }
    }
}