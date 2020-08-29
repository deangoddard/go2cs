//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:49 UTC
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
                this._unused = default;
                this.signal = default;
                this._pad0 = default;
                this.handler = default;
                this.oldmask = default;
                this.regs = default;
                this.gp_regs = default;
                this.fp_regs = default;
                this.v_regs = default;
                this.vmx_reserve = default;
            }

            public sigcontext(array<ulong> _unused = default, int signal = default, int _pad0 = default, ulong handler = default, ulong oldmask = default, ref ptr<ptregs> regs = default, array<ulong> gp_regs = default, array<double> fp_regs = default, ref ptr<vreg> v_regs = default, array<long> vmx_reserve = default)
            {
                this._unused = _unused;
                this.signal = signal;
                this._pad0 = _pad0;
                this.handler = handler;
                this.oldmask = oldmask;
                this.regs = regs;
                this.gp_regs = gp_regs;
                this.fp_regs = fp_regs;
                this.v_regs = v_regs;
                this.vmx_reserve = vmx_reserve;
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
            return new sigcontext(value._unused, value.signal, value._pad0, value.handler, value.oldmask, ref value.regs, value.gp_regs, value.fp_regs, ref value.v_regs, value.vmx_reserve);
        }
    }
}