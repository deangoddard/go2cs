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
        public partial struct IfData
        {
            // Constructors
            public IfData(NilType _)
            {
                this.Type = default;
                this.Addrlen = default;
                this.Hdrlen = default;
                this.Link_state = default;
                this.Mtu = default;
                this.Metric = default;
                this.Pad = default;
                this.Baudrate = default;
                this.Ipackets = default;
                this.Ierrors = default;
                this.Opackets = default;
                this.Oerrors = default;
                this.Collisions = default;
                this.Ibytes = default;
                this.Obytes = default;
                this.Imcasts = default;
                this.Omcasts = default;
                this.Iqdrops = default;
                this.Noproto = default;
                this.Capabilities = default;
                this.Pad_cgo_0 = default;
                this.Lastchange = default;
                this.Mclpool = default;
                this.Pad_cgo_1 = default;
            }

            public IfData(byte Type = default, byte Addrlen = default, byte Hdrlen = default, byte Link_state = default, uint Mtu = default, uint Metric = default, uint Pad = default, ulong Baudrate = default, ulong Ipackets = default, ulong Ierrors = default, ulong Opackets = default, ulong Oerrors = default, ulong Collisions = default, ulong Ibytes = default, ulong Obytes = default, ulong Imcasts = default, ulong Omcasts = default, ulong Iqdrops = default, ulong Noproto = default, uint Capabilities = default, array<byte> Pad_cgo_0 = default, Timeval Lastchange = default, array<Mclpool> Mclpool = default, array<byte> Pad_cgo_1 = default)
            {
                this.Type = Type;
                this.Addrlen = Addrlen;
                this.Hdrlen = Hdrlen;
                this.Link_state = Link_state;
                this.Mtu = Mtu;
                this.Metric = Metric;
                this.Pad = Pad;
                this.Baudrate = Baudrate;
                this.Ipackets = Ipackets;
                this.Ierrors = Ierrors;
                this.Opackets = Opackets;
                this.Oerrors = Oerrors;
                this.Collisions = Collisions;
                this.Ibytes = Ibytes;
                this.Obytes = Obytes;
                this.Imcasts = Imcasts;
                this.Omcasts = Omcasts;
                this.Iqdrops = Iqdrops;
                this.Noproto = Noproto;
                this.Capabilities = Capabilities;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Lastchange = Lastchange;
                this.Mclpool = Mclpool;
                this.Pad_cgo_1 = Pad_cgo_1;
            }

            // Enable comparisons between nil and IfData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfData value, NilType nil) => value.Equals(default(IfData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfData(NilType nil) => default(IfData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfData IfData_cast(dynamic value)
        {
            return new IfData(value.Type, value.Addrlen, value.Hdrlen, value.Link_state, value.Mtu, value.Metric, value.Pad, value.Baudrate, value.Ipackets, value.Ierrors, value.Opackets, value.Oerrors, value.Collisions, value.Ibytes, value.Obytes, value.Imcasts, value.Omcasts, value.Iqdrops, value.Noproto, value.Capabilities, value.Pad_cgo_0, value.Lastchange, value.Mclpool, value.Pad_cgo_1);
        }
    }
}