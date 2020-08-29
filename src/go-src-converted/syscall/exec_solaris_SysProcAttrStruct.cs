//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:37:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SysProcAttr
        {
            // Constructors
            public SysProcAttr(NilType _)
            {
                this.Chroot = default;
                this.Credential = default;
                this.Setsid = default;
                this.Setpgid = default;
                this.Setctty = default;
                this.Noctty = default;
                this.Ctty = default;
                this.Foreground = default;
                this.Pgid = default;
            }

            public SysProcAttr(@string Chroot = default, ref ptr<Credential> Credential = default, bool Setsid = default, bool Setpgid = default, bool Setctty = default, bool Noctty = default, long Ctty = default, bool Foreground = default, long Pgid = default)
            {
                this.Chroot = Chroot;
                this.Credential = Credential;
                this.Setsid = Setsid;
                this.Setpgid = Setpgid;
                this.Setctty = Setctty;
                this.Noctty = Noctty;
                this.Ctty = Ctty;
                this.Foreground = Foreground;
                this.Pgid = Pgid;
            }

            // Enable comparisons between nil and SysProcAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SysProcAttr value, NilType nil) => value.Equals(default(SysProcAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SysProcAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SysProcAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SysProcAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SysProcAttr(NilType nil) => default(SysProcAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SysProcAttr SysProcAttr_cast(dynamic value)
        {
            return new SysProcAttr(value.Chroot, ref value.Credential, value.Setsid, value.Setpgid, value.Setctty, value.Noctty, value.Ctty, value.Foreground, value.Pgid);
        }
    }
}