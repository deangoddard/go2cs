//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:31 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct InterfaceMessage
        {
            // Constructors
            public InterfaceMessage(NilType _)
            {
                this.Version = default;
                this.Type = default;
                this.Flags = default;
                this.Index = default;
                this.Name = default;
                this.Addrs = default;
                this.extOff = default;
                this.raw = default;
            }

            public InterfaceMessage(nint Version = default, nint Type = default, nint Flags = default, nint Index = default, @string Name = default, slice<Addr> Addrs = default, nint extOff = default, slice<byte> raw = default)
            {
                this.Version = Version;
                this.Type = Type;
                this.Flags = Flags;
                this.Index = Index;
                this.Name = Name;
                this.Addrs = Addrs;
                this.extOff = extOff;
                this.raw = raw;
            }

            // Enable comparisons between nil and InterfaceMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceMessage value, NilType nil) => value.Equals(default(InterfaceMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceMessage(NilType nil) => default(InterfaceMessage);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static InterfaceMessage InterfaceMessage_cast(dynamic value)
        {
            return new InterfaceMessage(value.Version, value.Type, value.Flags, value.Index, value.Name, value.Addrs, value.extOff, value.raw);
        }
    }
}}}}}