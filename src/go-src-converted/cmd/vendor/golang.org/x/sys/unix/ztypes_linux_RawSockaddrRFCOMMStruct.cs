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
        public partial struct RawSockaddrRFCOMM
        {
            // Constructors
            public RawSockaddrRFCOMM(NilType _)
            {
                this.Family = default;
                this.Bdaddr = default;
                this.Channel = default;
                this._ = default;
            }

            public RawSockaddrRFCOMM(ushort Family = default, array<byte> Bdaddr = default, byte Channel = default, array<byte> _ = default)
            {
                this.Family = Family;
                this.Bdaddr = Bdaddr;
                this.Channel = Channel;
                this._ = _;
            }

            // Enable comparisons between nil and RawSockaddrRFCOMM struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrRFCOMM value, NilType nil) => value.Equals(default(RawSockaddrRFCOMM));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrRFCOMM value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrRFCOMM value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrRFCOMM value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrRFCOMM(NilType nil) => default(RawSockaddrRFCOMM);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrRFCOMM RawSockaddrRFCOMM_cast(dynamic value)
        {
            return new RawSockaddrRFCOMM(value.Family, value.Bdaddr, value.Channel, value._);
        }
    }
}}}}}}