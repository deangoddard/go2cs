//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:12 UTC
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
                this.Regs = default;
                this.U_tsize = default;
                this.U_dsize = default;
                this.U_ssize = default;
                this.Start_code = default;
                this.Start_data = default;
                this.Start_stack = default;
                this.Signal = default;
                this.U_ar0 = default;
                this.Magic = default;
                this.U_comm = default;
            }

            public PtraceRegs(array<ulong> Regs = default, ulong U_tsize = default, ulong U_dsize = default, ulong U_ssize = default, ulong Start_code = default, ulong Start_data = default, ulong Start_stack = default, long Signal = default, ulong U_ar0 = default, ulong Magic = default, array<sbyte> U_comm = default)
            {
                this.Regs = Regs;
                this.U_tsize = U_tsize;
                this.U_dsize = U_dsize;
                this.U_ssize = U_ssize;
                this.Start_code = Start_code;
                this.Start_data = Start_data;
                this.Start_stack = Start_stack;
                this.Signal = Signal;
                this.U_ar0 = U_ar0;
                this.Magic = Magic;
                this.U_comm = U_comm;
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
            return new PtraceRegs(value.Regs, value.U_tsize, value.U_dsize, value.U_ssize, value.Start_code, value.Start_data, value.Start_stack, value.Signal, value.U_ar0, value.Magic, value.U_comm);
        }
    }
}