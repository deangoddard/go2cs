//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:10 UTC
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
        public partial struct Inet6Pktinfo
        {
            // Constructors
            public Inet6Pktinfo(NilType _)
            {
                this.Addr = default;
                this.Ifindex = default;
            }

            public Inet6Pktinfo(array<byte> Addr = default, uint Ifindex = default)
            {
                this.Addr = Addr;
                this.Ifindex = Ifindex;
            }

            // Enable comparisons between nil and Inet6Pktinfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Inet6Pktinfo value, NilType nil) => value.Equals(default(Inet6Pktinfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Inet6Pktinfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Inet6Pktinfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Inet6Pktinfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Inet6Pktinfo(NilType nil) => default(Inet6Pktinfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Inet6Pktinfo Inet6Pktinfo_cast(dynamic value)
        {
            return new Inet6Pktinfo(value.Addr, value.Ifindex);
        }
    }
}