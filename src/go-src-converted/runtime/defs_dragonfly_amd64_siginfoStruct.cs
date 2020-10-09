//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:48 UTC
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
        private partial struct siginfo
        {
            // Constructors
            public siginfo(NilType _)
            {
                this.si_signo = default;
                this.si_errno = default;
                this.si_code = default;
                this.si_pid = default;
                this.si_uid = default;
                this.si_status = default;
                this.si_addr = default;
                this.si_value = default;
                this.si_band = default;
                this.__spare__ = default;
                this.pad_cgo_0 = default;
            }

            public siginfo(int si_signo = default, int si_errno = default, int si_code = default, int si_pid = default, uint si_uid = default, int si_status = default, ulong si_addr = default, array<byte> si_value = default, long si_band = default, array<int> __spare__ = default, array<byte> pad_cgo_0 = default)
            {
                this.si_signo = si_signo;
                this.si_errno = si_errno;
                this.si_code = si_code;
                this.si_pid = si_pid;
                this.si_uid = si_uid;
                this.si_status = si_status;
                this.si_addr = si_addr;
                this.si_value = si_value;
                this.si_band = si_band;
                this.__spare__ = __spare__;
                this.pad_cgo_0 = pad_cgo_0;
            }

            // Enable comparisons between nil and siginfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(siginfo value, NilType nil) => value.Equals(default(siginfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(siginfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, siginfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, siginfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator siginfo(NilType nil) => default(siginfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static siginfo siginfo_cast(dynamic value)
        {
            return new siginfo(value.si_signo, value.si_errno, value.si_code, value.si_pid, value.si_uid, value.si_status, value.si_addr, value.si_value, value.si_band, value.__spare__, value.pad_cgo_0);
        }
    }
}