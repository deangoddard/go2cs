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
        public partial struct RawSockaddrL2TPIP
        {
            // Constructors
            public RawSockaddrL2TPIP(NilType _)
            {
                this.Family = default;
                this.Unused = default;
                this.Addr = default;
                this.Conn_id = default;
                this._ = default;
            }

            public RawSockaddrL2TPIP(ushort Family = default, ushort Unused = default, array<byte> Addr = default, uint Conn_id = default, array<byte> _ = default)
            {
                this.Family = Family;
                this.Unused = Unused;
                this.Addr = Addr;
                this.Conn_id = Conn_id;
                this._ = _;
            }

            // Enable comparisons between nil and RawSockaddrL2TPIP struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrL2TPIP value, NilType nil) => value.Equals(default(RawSockaddrL2TPIP));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrL2TPIP value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrL2TPIP value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrL2TPIP value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrL2TPIP(NilType nil) => default(RawSockaddrL2TPIP);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrL2TPIP RawSockaddrL2TPIP_cast(dynamic value)
        {
            return new RawSockaddrL2TPIP(value.Family, value.Unused, value.Addr, value.Conn_id, value._);
        }
    }
}}}}}}