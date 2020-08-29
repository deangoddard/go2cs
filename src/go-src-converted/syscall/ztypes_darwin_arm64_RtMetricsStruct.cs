//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:04 UTC
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
        public partial struct RtMetrics
        {
            // Constructors
            public RtMetrics(NilType _)
            {
                this.Locks = default;
                this.Mtu = default;
                this.Hopcount = default;
                this.Expire = default;
                this.Recvpipe = default;
                this.Sendpipe = default;
                this.Ssthresh = default;
                this.Rtt = default;
                this.Rttvar = default;
                this.Pksent = default;
                this.Filler = default;
            }

            public RtMetrics(uint Locks = default, uint Mtu = default, uint Hopcount = default, int Expire = default, uint Recvpipe = default, uint Sendpipe = default, uint Ssthresh = default, uint Rtt = default, uint Rttvar = default, uint Pksent = default, array<uint> Filler = default)
            {
                this.Locks = Locks;
                this.Mtu = Mtu;
                this.Hopcount = Hopcount;
                this.Expire = Expire;
                this.Recvpipe = Recvpipe;
                this.Sendpipe = Sendpipe;
                this.Ssthresh = Ssthresh;
                this.Rtt = Rtt;
                this.Rttvar = Rttvar;
                this.Pksent = Pksent;
                this.Filler = Filler;
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
            return new RtMetrics(value.Locks, value.Mtu, value.Hopcount, value.Expire, value.Recvpipe, value.Sendpipe, value.Ssthresh, value.Rtt, value.Rttvar, value.Pksent, value.Filler);
        }
    }
}