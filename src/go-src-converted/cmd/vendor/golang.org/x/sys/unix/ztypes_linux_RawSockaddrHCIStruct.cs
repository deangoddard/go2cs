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
        public partial struct RawSockaddrHCI
        {
            // Constructors
            public RawSockaddrHCI(NilType _)
            {
                this.Family = default;
                this.Dev = default;
                this.Channel = default;
            }

            public RawSockaddrHCI(ushort Family = default, ushort Dev = default, ushort Channel = default)
            {
                this.Family = Family;
                this.Dev = Dev;
                this.Channel = Channel;
            }

            // Enable comparisons between nil and RawSockaddrHCI struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrHCI value, NilType nil) => value.Equals(default(RawSockaddrHCI));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrHCI value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrHCI value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrHCI value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrHCI(NilType nil) => default(RawSockaddrHCI);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrHCI RawSockaddrHCI_cast(dynamic value)
        {
            return new RawSockaddrHCI(value.Family, value.Dev, value.Channel);
        }
    }
}}}}}}