//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:51:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using poll = go.@internal.poll_package;
using unix = go.@internal.syscall.unix_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rawSockaddrDatalink
        {
            // Constructors
            public rawSockaddrDatalink(NilType _)
            {
                this.Len = default;
                this.Family = default;
                this.Index = default;
                this.Type = default;
                this.Nlen = default;
                this.Alen = default;
                this.Slen = default;
                this.Data = default;
            }

            public rawSockaddrDatalink(byte Len = default, byte Family = default, ushort Index = default, byte Type = default, byte Nlen = default, byte Alen = default, byte Slen = default, array<byte> Data = default)
            {
                this.Len = Len;
                this.Family = Family;
                this.Index = Index;
                this.Type = Type;
                this.Nlen = Nlen;
                this.Alen = Alen;
                this.Slen = Slen;
                this.Data = Data;
            }

            // Enable comparisons between nil and rawSockaddrDatalink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rawSockaddrDatalink value, NilType nil) => value.Equals(default(rawSockaddrDatalink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rawSockaddrDatalink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rawSockaddrDatalink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rawSockaddrDatalink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rawSockaddrDatalink(NilType nil) => default(rawSockaddrDatalink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rawSockaddrDatalink rawSockaddrDatalink_cast(dynamic value)
        {
            return new rawSockaddrDatalink(value.Len, value.Family, value.Index, value.Type, value.Nlen, value.Alen, value.Slen, value.Data);
        }
    }
}