//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:50 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct siginfo
        {
            // Constructors
            public siginfo(NilType _)
            {
                this.si_signo = default;
                this.si_code = default;
                this.si_errno = default;
                this._data = default;
            }

            public siginfo(int si_signo = default, int si_code = default, int si_errno = default, array<byte> _data = default)
            {
                this.si_signo = si_signo;
                this.si_code = si_code;
                this.si_errno = si_errno;
                this._data = _data;
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
            return new siginfo(value.si_signo, value.si_code, value.si_errno, value._data);
        }
    }
}