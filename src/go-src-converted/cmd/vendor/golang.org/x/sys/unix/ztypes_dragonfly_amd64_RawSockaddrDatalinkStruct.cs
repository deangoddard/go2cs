//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:28 UTC
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
        public partial struct RawSockaddrDatalink
        {
            // Constructors
            public RawSockaddrDatalink(NilType _)
            {
                this.Len = default;
                this.Family = default;
                this.Index = default;
                this.Type = default;
                this.Nlen = default;
                this.Alen = default;
                this.Slen = default;
                this.Data = default;
                this.Rcf = default;
                this.Route = default;
            }

            public RawSockaddrDatalink(byte Len = default, byte Family = default, ushort Index = default, byte Type = default, byte Nlen = default, byte Alen = default, byte Slen = default, array<sbyte> Data = default, ushort Rcf = default, array<ushort> Route = default)
            {
                this.Len = Len;
                this.Family = Family;
                this.Index = Index;
                this.Type = Type;
                this.Nlen = Nlen;
                this.Alen = Alen;
                this.Slen = Slen;
                this.Data = Data;
                this.Rcf = Rcf;
                this.Route = Route;
            }

            // Enable comparisons between nil and RawSockaddrDatalink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrDatalink value, NilType nil) => value.Equals(default(RawSockaddrDatalink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrDatalink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrDatalink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrDatalink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrDatalink(NilType nil) => default(RawSockaddrDatalink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrDatalink RawSockaddrDatalink_cast(dynamic value)
        {
            return new RawSockaddrDatalink(value.Len, value.Family, value.Index, value.Type, value.Nlen, value.Alen, value.Slen, value.Data, value.Rcf, value.Route);
        }
    }
}}}}}}