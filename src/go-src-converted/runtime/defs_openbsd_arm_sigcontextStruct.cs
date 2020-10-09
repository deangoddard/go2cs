//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

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
                this.__sc_unused = default;
                this.sc_mask = default;
                this.sc_spsr = default;
                this.sc_r0 = default;
                this.sc_r1 = default;
                this.sc_r2 = default;
                this.sc_r3 = default;
                this.sc_r4 = default;
                this.sc_r5 = default;
                this.sc_r6 = default;
                this.sc_r7 = default;
                this.sc_r8 = default;
                this.sc_r9 = default;
                this.sc_r10 = default;
                this.sc_r11 = default;
                this.sc_r12 = default;
                this.sc_usr_sp = default;
                this.sc_usr_lr = default;
                this.sc_svc_lr = default;
                this.sc_pc = default;
                this.sc_fpused = default;
                this.sc_fpscr = default;
                this.sc_fpreg = default;
            }

            public sigcontext(int __sc_unused = default, int sc_mask = default, uint sc_spsr = default, uint sc_r0 = default, uint sc_r1 = default, uint sc_r2 = default, uint sc_r3 = default, uint sc_r4 = default, uint sc_r5 = default, uint sc_r6 = default, uint sc_r7 = default, uint sc_r8 = default, uint sc_r9 = default, uint sc_r10 = default, uint sc_r11 = default, uint sc_r12 = default, uint sc_usr_sp = default, uint sc_usr_lr = default, uint sc_svc_lr = default, uint sc_pc = default, uint sc_fpused = default, uint sc_fpscr = default, array<ulong> sc_fpreg = default)
            {
                this.__sc_unused = __sc_unused;
                this.sc_mask = sc_mask;
                this.sc_spsr = sc_spsr;
                this.sc_r0 = sc_r0;
                this.sc_r1 = sc_r1;
                this.sc_r2 = sc_r2;
                this.sc_r3 = sc_r3;
                this.sc_r4 = sc_r4;
                this.sc_r5 = sc_r5;
                this.sc_r6 = sc_r6;
                this.sc_r7 = sc_r7;
                this.sc_r8 = sc_r8;
                this.sc_r9 = sc_r9;
                this.sc_r10 = sc_r10;
                this.sc_r11 = sc_r11;
                this.sc_r12 = sc_r12;
                this.sc_usr_sp = sc_usr_sp;
                this.sc_usr_lr = sc_usr_lr;
                this.sc_svc_lr = sc_svc_lr;
                this.sc_pc = sc_pc;
                this.sc_fpused = sc_fpused;
                this.sc_fpscr = sc_fpscr;
                this.sc_fpreg = sc_fpreg;
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
            return new sigcontext(value.__sc_unused, value.sc_mask, value.sc_spsr, value.sc_r0, value.sc_r1, value.sc_r2, value.sc_r3, value.sc_r4, value.sc_r5, value.sc_r6, value.sc_r7, value.sc_r8, value.sc_r9, value.sc_r10, value.sc_r11, value.sc_r12, value.sc_usr_sp, value.sc_usr_lr, value.sc_svc_lr, value.sc_pc, value.sc_fpused, value.sc_fpscr, value.sc_fpreg);
        }
    }
}