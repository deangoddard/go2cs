//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:46 UTC
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
        public partial struct IPv6Mreq
        {
            // Constructors
            public IPv6Mreq(NilType _)
            {
                this.Multiaddr = default;
                this.Interface = default;
            }

            public IPv6Mreq(array<byte> Multiaddr = default, uint Interface = default)
            {
                this.Multiaddr = Multiaddr;
                this.Interface = Interface;
            }

            // Enable comparisons between nil and IPv6Mreq struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IPv6Mreq value, NilType nil) => value.Equals(default(IPv6Mreq));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IPv6Mreq value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IPv6Mreq value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IPv6Mreq value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IPv6Mreq(NilType nil) => default(IPv6Mreq);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IPv6Mreq IPv6Mreq_cast(dynamic value)
        {
            return new IPv6Mreq(value.Multiaddr, value.Interface);
        }
    }
}}}}}}