//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using itoa = go.@internal.itoa_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrLinklayer
        {
            // Constructors
            public SockaddrLinklayer(NilType _)
            {
                this.Protocol = default;
                this.Ifindex = default;
                this.Hatype = default;
                this.Pkttype = default;
                this.Halen = default;
                this.Addr = default;
                this.raw = default;
            }

            public SockaddrLinklayer(ushort Protocol = default, nint Ifindex = default, ushort Hatype = default, byte Pkttype = default, byte Halen = default, array<byte> Addr = default, RawSockaddrLinklayer raw = default)
            {
                this.Protocol = Protocol;
                this.Ifindex = Ifindex;
                this.Hatype = Hatype;
                this.Pkttype = Pkttype;
                this.Halen = Halen;
                this.Addr = Addr;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrLinklayer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrLinklayer value, NilType nil) => value.Equals(default(SockaddrLinklayer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrLinklayer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrLinklayer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrLinklayer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrLinklayer(NilType nil) => default(SockaddrLinklayer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrLinklayer SockaddrLinklayer_cast(dynamic value)
        {
            return new SockaddrLinklayer(value.Protocol, value.Ifindex, value.Hatype, value.Pkttype, value.Halen, value.Addr, value.raw);
        }
    }
}