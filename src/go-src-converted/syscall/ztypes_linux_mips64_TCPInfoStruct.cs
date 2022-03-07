//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:50 UTC
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
        public partial struct TCPInfo
        {
            // Constructors
            public TCPInfo(NilType _)
            {
                this.State = default;
                this.Ca_state = default;
                this.Retransmits = default;
                this.Probes = default;
                this.Backoff = default;
                this.Options = default;
                this.Pad_cgo_0 = default;
                this.Rto = default;
                this.Ato = default;
                this.Snd_mss = default;
                this.Rcv_mss = default;
                this.Unacked = default;
                this.Sacked = default;
                this.Lost = default;
                this.Retrans = default;
                this.Fackets = default;
                this.Last_data_sent = default;
                this.Last_ack_sent = default;
                this.Last_data_recv = default;
                this.Last_ack_recv = default;
                this.Pmtu = default;
                this.Rcv_ssthresh = default;
                this.Rtt = default;
                this.Rttvar = default;
                this.Snd_ssthresh = default;
                this.Snd_cwnd = default;
                this.Advmss = default;
                this.Reordering = default;
                this.Rcv_rtt = default;
                this.Rcv_space = default;
                this.Total_retrans = default;
            }

            public TCPInfo(byte State = default, byte Ca_state = default, byte Retransmits = default, byte Probes = default, byte Backoff = default, byte Options = default, array<byte> Pad_cgo_0 = default, uint Rto = default, uint Ato = default, uint Snd_mss = default, uint Rcv_mss = default, uint Unacked = default, uint Sacked = default, uint Lost = default, uint Retrans = default, uint Fackets = default, uint Last_data_sent = default, uint Last_ack_sent = default, uint Last_data_recv = default, uint Last_ack_recv = default, uint Pmtu = default, uint Rcv_ssthresh = default, uint Rtt = default, uint Rttvar = default, uint Snd_ssthresh = default, uint Snd_cwnd = default, uint Advmss = default, uint Reordering = default, uint Rcv_rtt = default, uint Rcv_space = default, uint Total_retrans = default)
            {
                this.State = State;
                this.Ca_state = Ca_state;
                this.Retransmits = Retransmits;
                this.Probes = Probes;
                this.Backoff = Backoff;
                this.Options = Options;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Rto = Rto;
                this.Ato = Ato;
                this.Snd_mss = Snd_mss;
                this.Rcv_mss = Rcv_mss;
                this.Unacked = Unacked;
                this.Sacked = Sacked;
                this.Lost = Lost;
                this.Retrans = Retrans;
                this.Fackets = Fackets;
                this.Last_data_sent = Last_data_sent;
                this.Last_ack_sent = Last_ack_sent;
                this.Last_data_recv = Last_data_recv;
                this.Last_ack_recv = Last_ack_recv;
                this.Pmtu = Pmtu;
                this.Rcv_ssthresh = Rcv_ssthresh;
                this.Rtt = Rtt;
                this.Rttvar = Rttvar;
                this.Snd_ssthresh = Snd_ssthresh;
                this.Snd_cwnd = Snd_cwnd;
                this.Advmss = Advmss;
                this.Reordering = Reordering;
                this.Rcv_rtt = Rcv_rtt;
                this.Rcv_space = Rcv_space;
                this.Total_retrans = Total_retrans;
            }

            // Enable comparisons between nil and TCPInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TCPInfo value, NilType nil) => value.Equals(default(TCPInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TCPInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TCPInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TCPInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TCPInfo(NilType nil) => default(TCPInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TCPInfo TCPInfo_cast(dynamic value)
        {
            return new TCPInfo(value.State, value.Ca_state, value.Retransmits, value.Probes, value.Backoff, value.Options, value.Pad_cgo_0, value.Rto, value.Ato, value.Snd_mss, value.Rcv_mss, value.Unacked, value.Sacked, value.Lost, value.Retrans, value.Fackets, value.Last_data_sent, value.Last_ack_sent, value.Last_data_recv, value.Last_ack_recv, value.Pmtu, value.Rcv_ssthresh, value.Rtt, value.Rttvar, value.Snd_ssthresh, value.Snd_cwnd, value.Advmss, value.Reordering, value.Rcv_rtt, value.Rcv_space, value.Total_retrans);
        }
    }
}