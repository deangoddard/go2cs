//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:14 UTC
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
        public partial struct PtracePer
        {
            // Constructors
            public PtracePer(NilType _)
            {
                this.Control_regs = default;
                this._ = default;
                this._ = default;
                this.Starting_addr = default;
                this.Ending_addr = default;
                this.Perc_atmid = default;
                this._ = default;
                this.Address = default;
                this.Access_id = default;
                this._ = default;
            }

            public PtracePer(array<ulong> Control_regs = default, array<byte> _ = default, array<byte> _ = default, ulong Starting_addr = default, ulong Ending_addr = default, ushort Perc_atmid = default, array<byte> _ = default, ulong Address = default, byte Access_id = default, array<byte> _ = default)
            {
                this.Control_regs = Control_regs;
                this._ = _;
                this._ = _;
                this.Starting_addr = Starting_addr;
                this.Ending_addr = Ending_addr;
                this.Perc_atmid = Perc_atmid;
                this._ = _;
                this.Address = Address;
                this.Access_id = Access_id;
                this._ = _;
            }

            // Enable comparisons between nil and PtracePer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PtracePer value, NilType nil) => value.Equals(default(PtracePer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PtracePer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PtracePer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PtracePer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PtracePer(NilType nil) => default(PtracePer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PtracePer PtracePer_cast(dynamic value)
        {
            return new PtracePer(value.Control_regs, value._, value._, value.Starting_addr, value.Ending_addr, value.Perc_atmid, value._, value.Address, value.Access_id, value._);
        }
    }
}