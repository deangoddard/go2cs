//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IfData
        {
            // Constructors
            public IfData(NilType _)
            {
                this.Type = default;
                this.Physical = default;
                this.Addrlen = default;
                this.Hdrlen = default;
                this.Link_state = default;
                this.Spare_char1 = default;
                this.Spare_char2 = default;
                this.Datalen = default;
                this.Mtu = default;
                this.Metric = default;
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
                this.Hwassist = default;
                this.Epoch = default;
                this.Lastchange = default;
            }

            public IfData(byte Type = default, byte Physical = default, byte Addrlen = default, byte Hdrlen = default, byte Link_state = default, byte Spare_char1 = default, byte Spare_char2 = default, byte Datalen = default, ulong Mtu = default, ulong Metric = default, ulong Baudrate = default, ulong Ipackets = default, ulong Ierrors = default, ulong Opackets = default, ulong Oerrors = default, ulong Collisions = default, ulong Ibytes = default, ulong Obytes = default, ulong Imcasts = default, ulong Omcasts = default, ulong Iqdrops = default, ulong Noproto = default, ulong Hwassist = default, long Epoch = default, Timeval Lastchange = default)
            {
                this.Type = Type;
                this.Physical = Physical;
                this.Addrlen = Addrlen;
                this.Hdrlen = Hdrlen;
                this.Link_state = Link_state;
                this.Spare_char1 = Spare_char1;
                this.Spare_char2 = Spare_char2;
                this.Datalen = Datalen;
                this.Mtu = Mtu;
                this.Metric = Metric;
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
                this.Hwassist = Hwassist;
                this.Epoch = Epoch;
                this.Lastchange = Lastchange;
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
            return new IfData(value.Type, value.Physical, value.Addrlen, value.Hdrlen, value.Link_state, value.Spare_char1, value.Spare_char2, value.Datalen, value.Mtu, value.Metric, value.Baudrate, value.Ipackets, value.Ierrors, value.Opackets, value.Oerrors, value.Collisions, value.Ibytes, value.Obytes, value.Imcasts, value.Omcasts, value.Iqdrops, value.Noproto, value.Hwassist, value.Epoch, value.Lastchange);
        }
    }
}}}}}}