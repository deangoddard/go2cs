//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:12 UTC
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
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InterfaceAddrMessage
        {
            // Constructors
            public InterfaceAddrMessage(NilType _)
            {
                this.Version = default;
                this.Type = default;
                this.Flags = default;
                this.Index = default;
                this.Addrs = default;
                this.raw = default;
            }

            public InterfaceAddrMessage(nint Version = default, nint Type = default, nint Flags = default, nint Index = default, slice<Addr> Addrs = default, slice<byte> raw = default)
            {
                this.Version = Version;
                this.Type = Type;
                this.Flags = Flags;
                this.Index = Index;
                this.Addrs = Addrs;
                this.raw = raw;
            }

            // Enable comparisons between nil and InterfaceAddrMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceAddrMessage value, NilType nil) => value.Equals(default(InterfaceAddrMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceAddrMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceAddrMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceAddrMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceAddrMessage(NilType nil) => default(InterfaceAddrMessage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceAddrMessage InterfaceAddrMessage_cast(dynamic value)
        {
            return new InterfaceAddrMessage(value.Version, value.Type, value.Flags, value.Index, value.Addrs, value.raw);
        }
    }
}}}}}