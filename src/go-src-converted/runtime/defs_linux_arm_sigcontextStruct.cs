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
                this.trap_no = default;
                this.error_code = default;
                this.oldmask = default;
                this.r0 = default;
                this.r1 = default;
                this.r2 = default;
                this.r3 = default;
                this.r4 = default;
                this.r5 = default;
                this.r6 = default;
                this.r7 = default;
                this.r8 = default;
                this.r9 = default;
                this.r10 = default;
                this.fp = default;
                this.ip = default;
                this.sp = default;
                this.lr = default;
                this.pc = default;
                this.cpsr = default;
                this.fault_address = default;
            }

            public sigcontext(uint trap_no = default, uint error_code = default, uint oldmask = default, uint r0 = default, uint r1 = default, uint r2 = default, uint r3 = default, uint r4 = default, uint r5 = default, uint r6 = default, uint r7 = default, uint r8 = default, uint r9 = default, uint r10 = default, uint fp = default, uint ip = default, uint sp = default, uint lr = default, uint pc = default, uint cpsr = default, uint fault_address = default)
            {
                this.trap_no = trap_no;
                this.error_code = error_code;
                this.oldmask = oldmask;
                this.r0 = r0;
                this.r1 = r1;
                this.r2 = r2;
                this.r3 = r3;
                this.r4 = r4;
                this.r5 = r5;
                this.r6 = r6;
                this.r7 = r7;
                this.r8 = r8;
                this.r9 = r9;
                this.r10 = r10;
                this.fp = fp;
                this.ip = ip;
                this.sp = sp;
                this.lr = lr;
                this.pc = pc;
                this.cpsr = cpsr;
                this.fault_address = fault_address;
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
            return new sigcontext(value.trap_no, value.error_code, value.oldmask, value.r0, value.r1, value.r2, value.r3, value.r4, value.r5, value.r6, value.r7, value.r8, value.r9, value.r10, value.fp, value.ip, value.sp, value.lr, value.pc, value.cpsr, value.fault_address);
        }
    }
}