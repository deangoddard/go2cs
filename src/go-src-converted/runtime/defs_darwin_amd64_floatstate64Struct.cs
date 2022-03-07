//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct floatstate64
        {
            // Constructors
            public floatstate64(NilType _)
            {
                this.fpu_reserved = default;
                this.fpu_fcw = default;
                this.fpu_fsw = default;
                this.fpu_ftw = default;
                this.fpu_rsrv1 = default;
                this.fpu_fop = default;
                this.fpu_ip = default;
                this.fpu_cs = default;
                this.fpu_rsrv2 = default;
                this.fpu_dp = default;
                this.fpu_ds = default;
                this.fpu_rsrv3 = default;
                this.fpu_mxcsr = default;
                this.fpu_mxcsrmask = default;
                this.fpu_stmm0 = default;
                this.fpu_stmm1 = default;
                this.fpu_stmm2 = default;
                this.fpu_stmm3 = default;
                this.fpu_stmm4 = default;
                this.fpu_stmm5 = default;
                this.fpu_stmm6 = default;
                this.fpu_stmm7 = default;
                this.fpu_xmm0 = default;
                this.fpu_xmm1 = default;
                this.fpu_xmm2 = default;
                this.fpu_xmm3 = default;
                this.fpu_xmm4 = default;
                this.fpu_xmm5 = default;
                this.fpu_xmm6 = default;
                this.fpu_xmm7 = default;
                this.fpu_xmm8 = default;
                this.fpu_xmm9 = default;
                this.fpu_xmm10 = default;
                this.fpu_xmm11 = default;
                this.fpu_xmm12 = default;
                this.fpu_xmm13 = default;
                this.fpu_xmm14 = default;
                this.fpu_xmm15 = default;
                this.fpu_rsrv4 = default;
                this.fpu_reserved1 = default;
            }

            public floatstate64(array<int> fpu_reserved = default, fpcontrol fpu_fcw = default, fpstatus fpu_fsw = default, byte fpu_ftw = default, byte fpu_rsrv1 = default, ushort fpu_fop = default, uint fpu_ip = default, ushort fpu_cs = default, ushort fpu_rsrv2 = default, uint fpu_dp = default, ushort fpu_ds = default, ushort fpu_rsrv3 = default, uint fpu_mxcsr = default, uint fpu_mxcsrmask = default, regmmst fpu_stmm0 = default, regmmst fpu_stmm1 = default, regmmst fpu_stmm2 = default, regmmst fpu_stmm3 = default, regmmst fpu_stmm4 = default, regmmst fpu_stmm5 = default, regmmst fpu_stmm6 = default, regmmst fpu_stmm7 = default, regxmm fpu_xmm0 = default, regxmm fpu_xmm1 = default, regxmm fpu_xmm2 = default, regxmm fpu_xmm3 = default, regxmm fpu_xmm4 = default, regxmm fpu_xmm5 = default, regxmm fpu_xmm6 = default, regxmm fpu_xmm7 = default, regxmm fpu_xmm8 = default, regxmm fpu_xmm9 = default, regxmm fpu_xmm10 = default, regxmm fpu_xmm11 = default, regxmm fpu_xmm12 = default, regxmm fpu_xmm13 = default, regxmm fpu_xmm14 = default, regxmm fpu_xmm15 = default, array<sbyte> fpu_rsrv4 = default, int fpu_reserved1 = default)
            {
                this.fpu_reserved = fpu_reserved;
                this.fpu_fcw = fpu_fcw;
                this.fpu_fsw = fpu_fsw;
                this.fpu_ftw = fpu_ftw;
                this.fpu_rsrv1 = fpu_rsrv1;
                this.fpu_fop = fpu_fop;
                this.fpu_ip = fpu_ip;
                this.fpu_cs = fpu_cs;
                this.fpu_rsrv2 = fpu_rsrv2;
                this.fpu_dp = fpu_dp;
                this.fpu_ds = fpu_ds;
                this.fpu_rsrv3 = fpu_rsrv3;
                this.fpu_mxcsr = fpu_mxcsr;
                this.fpu_mxcsrmask = fpu_mxcsrmask;
                this.fpu_stmm0 = fpu_stmm0;
                this.fpu_stmm1 = fpu_stmm1;
                this.fpu_stmm2 = fpu_stmm2;
                this.fpu_stmm3 = fpu_stmm3;
                this.fpu_stmm4 = fpu_stmm4;
                this.fpu_stmm5 = fpu_stmm5;
                this.fpu_stmm6 = fpu_stmm6;
                this.fpu_stmm7 = fpu_stmm7;
                this.fpu_xmm0 = fpu_xmm0;
                this.fpu_xmm1 = fpu_xmm1;
                this.fpu_xmm2 = fpu_xmm2;
                this.fpu_xmm3 = fpu_xmm3;
                this.fpu_xmm4 = fpu_xmm4;
                this.fpu_xmm5 = fpu_xmm5;
                this.fpu_xmm6 = fpu_xmm6;
                this.fpu_xmm7 = fpu_xmm7;
                this.fpu_xmm8 = fpu_xmm8;
                this.fpu_xmm9 = fpu_xmm9;
                this.fpu_xmm10 = fpu_xmm10;
                this.fpu_xmm11 = fpu_xmm11;
                this.fpu_xmm12 = fpu_xmm12;
                this.fpu_xmm13 = fpu_xmm13;
                this.fpu_xmm14 = fpu_xmm14;
                this.fpu_xmm15 = fpu_xmm15;
                this.fpu_rsrv4 = fpu_rsrv4;
                this.fpu_reserved1 = fpu_reserved1;
            }

            // Enable comparisons between nil and floatstate64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(floatstate64 value, NilType nil) => value.Equals(default(floatstate64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(floatstate64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, floatstate64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, floatstate64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator floatstate64(NilType nil) => default(floatstate64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static floatstate64 floatstate64_cast(dynamic value)
        {
            return new floatstate64(value.fpu_reserved, value.fpu_fcw, value.fpu_fsw, value.fpu_ftw, value.fpu_rsrv1, value.fpu_fop, value.fpu_ip, value.fpu_cs, value.fpu_rsrv2, value.fpu_dp, value.fpu_ds, value.fpu_rsrv3, value.fpu_mxcsr, value.fpu_mxcsrmask, value.fpu_stmm0, value.fpu_stmm1, value.fpu_stmm2, value.fpu_stmm3, value.fpu_stmm4, value.fpu_stmm5, value.fpu_stmm6, value.fpu_stmm7, value.fpu_xmm0, value.fpu_xmm1, value.fpu_xmm2, value.fpu_xmm3, value.fpu_xmm4, value.fpu_xmm5, value.fpu_xmm6, value.fpu_xmm7, value.fpu_xmm8, value.fpu_xmm9, value.fpu_xmm10, value.fpu_xmm11, value.fpu_xmm12, value.fpu_xmm13, value.fpu_xmm14, value.fpu_xmm15, value.fpu_rsrv4, value.fpu_reserved1);
        }
    }
}