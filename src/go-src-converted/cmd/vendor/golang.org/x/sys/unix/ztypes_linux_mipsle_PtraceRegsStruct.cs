//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PtraceRegs
        {
            // Constructors
            public PtraceRegs(NilType _)
            {
                this.Regs = default;
                this.Lo = default;
                this.Hi = default;
                this.Epc = default;
                this.Badvaddr = default;
                this.Status = default;
                this.Cause = default;
            }

            public PtraceRegs(array<ulong> Regs = default, ulong Lo = default, ulong Hi = default, ulong Epc = default, ulong Badvaddr = default, ulong Status = default, ulong Cause = default)
            {
                this.Regs = Regs;
                this.Lo = Lo;
                this.Hi = Hi;
                this.Epc = Epc;
                this.Badvaddr = Badvaddr;
                this.Status = Status;
                this.Cause = Cause;
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
            return new PtraceRegs(value.Regs, value.Lo, value.Hi, value.Epc, value.Badvaddr, value.Status, value.Cause);
        }
    }
}}}}}}