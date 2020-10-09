//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:23 UTC
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
                this.Locks = default;
                this.Mtu = default;
                this.Pksent = default;
                this.Expire = default;
                this.Sendpipe = default;
                this.Ssthresh = default;
                this.Rtt = default;
                this.Rttvar = default;
                this.Recvpipe = default;
                this.Hopcount = default;
                this.Mssopt = default;
                this.Pad = default;
                this.Pad_cgo_0 = default;
                this.Msl = default;
                this.Iwmaxsegs = default;
                this.Iwcapsegs = default;
            }

            public RtMetrics(ulong Locks = default, ulong Mtu = default, ulong Pksent = default, ulong Expire = default, ulong Sendpipe = default, ulong Ssthresh = default, ulong Rtt = default, ulong Rttvar = default, ulong Recvpipe = default, ulong Hopcount = default, ushort Mssopt = default, ushort Pad = default, array<byte> Pad_cgo_0 = default, ulong Msl = default, ulong Iwmaxsegs = default, ulong Iwcapsegs = default)
            {
                this.Locks = Locks;
                this.Mtu = Mtu;
                this.Pksent = Pksent;
                this.Expire = Expire;
                this.Sendpipe = Sendpipe;
                this.Ssthresh = Ssthresh;
                this.Rtt = Rtt;
                this.Rttvar = Rttvar;
                this.Recvpipe = Recvpipe;
                this.Hopcount = Hopcount;
                this.Mssopt = Mssopt;
                this.Pad = Pad;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Msl = Msl;
                this.Iwmaxsegs = Iwmaxsegs;
                this.Iwcapsegs = Iwcapsegs;
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
            return new RtMetrics(value.Locks, value.Mtu, value.Pksent, value.Expire, value.Sendpipe, value.Ssthresh, value.Rtt, value.Rttvar, value.Recvpipe, value.Hopcount, value.Mssopt, value.Pad, value.Pad_cgo_0, value.Msl, value.Iwmaxsegs, value.Iwcapsegs);
        }
    }
}