//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:30 UTC
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
        public partial struct Inet4Pktinfo
        {
            // Constructors
            public Inet4Pktinfo(NilType _)
            {
                this.Ifindex = default;
                this.Spec_dst = default;
                this.Addr = default;
            }

            public Inet4Pktinfo(int Ifindex = default, array<byte> Spec_dst = default, array<byte> Addr = default)
            {
                this.Ifindex = Ifindex;
                this.Spec_dst = Spec_dst;
                this.Addr = Addr;
            }

            // Enable comparisons between nil and Inet4Pktinfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Inet4Pktinfo value, NilType nil) => value.Equals(default(Inet4Pktinfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Inet4Pktinfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Inet4Pktinfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Inet4Pktinfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Inet4Pktinfo(NilType nil) => default(Inet4Pktinfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Inet4Pktinfo Inet4Pktinfo_cast(dynamic value)
        {
            return new Inet4Pktinfo(value.Ifindex, value.Spec_dst, value.Addr);
        }
    }
}