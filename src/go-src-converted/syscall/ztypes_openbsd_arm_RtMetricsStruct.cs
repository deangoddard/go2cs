//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RtMetrics
        {
            // Constructors
            public RtMetrics(NilType _)
            {
                this.Pksent = default;
                this.Expire = default;
                this.Locks = default;
                this.Mtu = default;
                this.Refcnt = default;
                this.Hopcount = default;
                this.Recvpipe = default;
                this.Sendpipe = default;
                this.Ssthresh = default;
                this.Rtt = default;
                this.Rttvar = default;
                this.Pad = default;
            }

            public RtMetrics(ulong Pksent = default, long Expire = default, uint Locks = default, uint Mtu = default, uint Refcnt = default, uint Hopcount = default, uint Recvpipe = default, uint Sendpipe = default, uint Ssthresh = default, uint Rtt = default, uint Rttvar = default, uint Pad = default)
            {
                this.Pksent = Pksent;
                this.Expire = Expire;
                this.Locks = Locks;
                this.Mtu = Mtu;
                this.Refcnt = Refcnt;
                this.Hopcount = Hopcount;
                this.Recvpipe = Recvpipe;
                this.Sendpipe = Sendpipe;
                this.Ssthresh = Ssthresh;
                this.Rtt = Rtt;
                this.Rttvar = Rttvar;
                this.Pad = Pad;
            }

            // Enable comparisons between nil and RtMetrics struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtMetrics value, NilType nil) => value.Equals(default(RtMetrics));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtMetrics value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtMetrics value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtMetrics value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtMetrics(NilType nil) => default(RtMetrics);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtMetrics RtMetrics_cast(dynamic value)
        {
            return new RtMetrics(value.Pksent, value.Expire, value.Locks, value.Mtu, value.Refcnt, value.Hopcount, value.Recvpipe, value.Sendpipe, value.Ssthresh, value.Rtt, value.Rttvar, value.Pad);
        }
    }
}