//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:27:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrDatalink
        {
            // Constructors
            public SockaddrDatalink(NilType _)
            {
                this.Family = default;
                this.Index = default;
                this.Type = default;
                this.Nlen = default;
                this.Alen = default;
                this.Slen = default;
                this.Data = default;
                this.raw = default;
            }

            public SockaddrDatalink(ushort Family = default, ushort Index = default, byte Type = default, byte Nlen = default, byte Alen = default, byte Slen = default, array<sbyte> Data = default, RawSockaddrDatalink raw = default)
            {
                this.Family = Family;
                this.Index = Index;
                this.Type = Type;
                this.Nlen = Nlen;
                this.Alen = Alen;
                this.Slen = Slen;
                this.Data = Data;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrDatalink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrDatalink value, NilType nil) => value.Equals(default(SockaddrDatalink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrDatalink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrDatalink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrDatalink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrDatalink(NilType nil) => default(SockaddrDatalink);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrDatalink SockaddrDatalink_cast(dynamic value)
        {
            return new SockaddrDatalink(value.Family, value.Index, value.Type, value.Nlen, value.Alen, value.Slen, value.Data, value.raw);
        }
    }
}