//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IpAdapterAnycastAddress
        {
            // Constructors
            public IpAdapterAnycastAddress(NilType _)
            {
                this.Length = default;
                this.Flags = default;
                this.Next = default;
                this.Address = default;
            }

            public IpAdapterAnycastAddress(uint Length = default, uint Flags = default, ref ptr<IpAdapterAnycastAddress> Next = default, SocketAddress Address = default)
            {
                this.Length = Length;
                this.Flags = Flags;
                this.Next = Next;
                this.Address = Address;
            }

            // Enable comparisons between nil and IpAdapterAnycastAddress struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IpAdapterAnycastAddress value, NilType nil) => value.Equals(default(IpAdapterAnycastAddress));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IpAdapterAnycastAddress value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IpAdapterAnycastAddress value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IpAdapterAnycastAddress value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpAdapterAnycastAddress(NilType nil) => default(IpAdapterAnycastAddress);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IpAdapterAnycastAddress IpAdapterAnycastAddress_cast(dynamic value)
        {
            return new IpAdapterAnycastAddress(value.Length, value.Flags, ref value.Next, value.Address);
        }
    }
}}}}}}