//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct forkRet
        {
            // Constructors
            public forkRet(NilType _)
            {
                this.pid = default;
                this.err = default;
            }

            public forkRet(long pid = default, error err = default)
            {
                this.pid = pid;
                this.err = err;
            }

            // Enable comparisons between nil and forkRet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(forkRet value, NilType nil) => value.Equals(default(forkRet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(forkRet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, forkRet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, forkRet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator forkRet(NilType nil) => default(forkRet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static forkRet forkRet_cast(dynamic value)
        {
            return new forkRet(value.pid, value.err);
        }
    }
}