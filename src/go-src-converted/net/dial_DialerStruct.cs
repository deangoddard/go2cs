//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using nettrace = go.@internal.nettrace_package;
using syscall = go.syscall_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dialer
        {
            // Constructors
            public Dialer(NilType _)
            {
                this.Timeout = default;
                this.Deadline = default;
                this.LocalAddr = default;
                this.DualStack = default;
                this.FallbackDelay = default;
                this.KeepAlive = default;
                this.Resolver = default;
                this.Cancel = default;
                this.Control = default;
            }

            public Dialer(time.Duration Timeout = default, time.Time Deadline = default, Addr LocalAddr = default, bool DualStack = default, time.Duration FallbackDelay = default, time.Duration KeepAlive = default, ref ptr<Resolver> Resolver = default, channel<object> Cancel = default, Func<@string, @string, syscall.RawConn, error> Control = default)
            {
                this.Timeout = Timeout;
                this.Deadline = Deadline;
                this.LocalAddr = LocalAddr;
                this.DualStack = DualStack;
                this.FallbackDelay = FallbackDelay;
                this.KeepAlive = KeepAlive;
                this.Resolver = Resolver;
                this.Cancel = Cancel;
                this.Control = Control;
            }

            // Enable comparisons between nil and Dialer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dialer value, NilType nil) => value.Equals(default(Dialer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dialer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dialer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dialer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dialer(NilType nil) => default(Dialer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Dialer Dialer_cast(dynamic value)
        {
            return new Dialer(value.Timeout, value.Deadline, value.LocalAddr, value.DualStack, value.FallbackDelay, value.KeepAlive, ref value.Resolver, value.Cancel, value.Control);
        }
    }
}