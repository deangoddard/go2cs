//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:29 UTC
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
        public partial struct IfmaMsghdr
        {
            // Constructors
            public IfmaMsghdr(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Addrs = default;
                this.Flags = default;
                this.Index = default;
                this._ = default;
            }

            public IfmaMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, int Addrs = default, int Flags = default, ushort Index = default, array<byte> _ = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Index = Index;
                this._ = _;
            }

            // Enable comparisons between nil and IfmaMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfmaMsghdr value, NilType nil) => value.Equals(default(IfmaMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfmaMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfmaMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfmaMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfmaMsghdr(NilType nil) => default(IfmaMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfmaMsghdr IfmaMsghdr_cast(dynamic value)
        {
            return new IfmaMsghdr(value.Msglen, value.Version, value.Type, value.Addrs, value.Flags, value.Index, value._);
        }
    }
}}}}}}