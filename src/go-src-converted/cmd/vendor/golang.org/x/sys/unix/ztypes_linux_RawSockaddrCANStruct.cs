//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
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
        public partial struct RawSockaddrCAN
        {
            // Constructors
            public RawSockaddrCAN(NilType _)
            {
                this.Family = default;
                this.Ifindex = default;
                this.Addr = default;
            }

            public RawSockaddrCAN(ushort Family = default, int Ifindex = default, array<byte> Addr = default)
            {
                this.Family = Family;
                this.Ifindex = Ifindex;
                this.Addr = Addr;
            }

            // Enable comparisons between nil and RawSockaddrCAN struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrCAN value, NilType nil) => value.Equals(default(RawSockaddrCAN));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrCAN value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrCAN value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrCAN value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrCAN(NilType nil) => default(RawSockaddrCAN);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrCAN RawSockaddrCAN_cast(dynamic value)
        {
            return new RawSockaddrCAN(value.Family, value.Ifindex, value.Addr);
        }
    }
}}}}}}