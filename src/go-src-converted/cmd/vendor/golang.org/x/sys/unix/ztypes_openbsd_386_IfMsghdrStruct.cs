//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:31 UTC
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
        public partial struct IfMsghdr
        {
            // Constructors
            public IfMsghdr(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Hdrlen = default;
                this.Index = default;
                this.Tableid = default;
                this.Pad1 = default;
                this.Pad2 = default;
                this.Addrs = default;
                this.Flags = default;
                this.Xflags = default;
                this.Data = default;
            }

            public IfMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, ushort Hdrlen = default, ushort Index = default, ushort Tableid = default, byte Pad1 = default, byte Pad2 = default, int Addrs = default, int Flags = default, int Xflags = default, IfData Data = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Hdrlen = Hdrlen;
                this.Index = Index;
                this.Tableid = Tableid;
                this.Pad1 = Pad1;
                this.Pad2 = Pad2;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Xflags = Xflags;
                this.Data = Data;
            }

            // Enable comparisons between nil and IfMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfMsghdr value, NilType nil) => value.Equals(default(IfMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfMsghdr(NilType nil) => default(IfMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfMsghdr IfMsghdr_cast(dynamic value)
        {
            return new IfMsghdr(value.Msglen, value.Version, value.Type, value.Hdrlen, value.Index, value.Tableid, value.Pad1, value.Pad2, value.Addrs, value.Flags, value.Xflags, value.Data);
        }
    }
}}}}}}