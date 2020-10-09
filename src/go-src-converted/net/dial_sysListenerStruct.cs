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
        [PromotedStruct(typeof(ListenConfig))]
        private partial struct sysListener
        {
            // ListenConfig structure promotion - sourced from value copy
            private readonly ptr<ListenConfig> m_ListenConfigRef;

            private ref ListenConfig ListenConfig_val => ref m_ListenConfigRef.Value;

            public ref Func<@string, @string, syscall.RawConn, error> Control => ref m_ListenConfigRef.Value.Control;

            public ref time.Duration KeepAlive => ref m_ListenConfigRef.Value.KeepAlive;

            // Constructors
            public sysListener(NilType _)
            {
                this.m_ListenConfigRef = new ptr<ListenConfig>(new ListenConfig(nil));
                this.network = default;
                this.address = default;
            }

            public sysListener(ListenConfig ListenConfig = default, @string network = default, @string address = default)
            {
                this.m_ListenConfigRef = new ptr<ListenConfig>(ListenConfig);
                this.network = network;
                this.address = address;
            }

            // Enable comparisons between nil and sysListener struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sysListener value, NilType nil) => value.Equals(default(sysListener));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sysListener value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sysListener value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sysListener value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sysListener(NilType nil) => default(sysListener);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sysListener sysListener_cast(dynamic value)
        {
            return new sysListener(value.ListenConfig, value.network, value.address);
        }
    }
}