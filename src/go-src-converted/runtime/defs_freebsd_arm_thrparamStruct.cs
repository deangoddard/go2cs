//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:49 UTC
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
        private partial struct thrparam
        {
            // Constructors
            public thrparam(NilType _)
            {
                this.start_func = default;
                this.arg = default;
                this.stack_base = default;
                this.stack_size = default;
                this.tls_base = default;
                this.tls_size = default;
                this.child_tid = default;
                this.parent_tid = default;
                this.flags = default;
                this.rtp = default;
                this.spare = default;
            }

            public thrparam(System.UIntPtr start_func = default, unsafe.Pointer arg = default, System.UIntPtr stack_base = default, System.UIntPtr stack_size = default, unsafe.Pointer tls_base = default, System.UIntPtr tls_size = default, unsafe.Pointer child_tid = default, ref ptr<int> parent_tid = default, int flags = default, ref ptr<rtprio> rtp = default, array<System.UIntPtr> spare = default)
            {
                this.start_func = start_func;
                this.arg = arg;
                this.stack_base = stack_base;
                this.stack_size = stack_size;
                this.tls_base = tls_base;
                this.tls_size = tls_size;
                this.child_tid = child_tid;
                this.parent_tid = parent_tid;
                this.flags = flags;
                this.rtp = rtp;
                this.spare = spare;
            }

            // Enable comparisons between nil and thrparam struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(thrparam value, NilType nil) => value.Equals(default(thrparam));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(thrparam value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, thrparam value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, thrparam value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator thrparam(NilType nil) => default(thrparam);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static thrparam thrparam_cast(dynamic value)
        {
            return new thrparam(value.start_func, value.arg, value.stack_base, value.stack_size, value.tls_base, value.tls_size, value.child_tid, ref value.parent_tid, value.flags, ref value.rtp, value.spare);
        }
    }
}