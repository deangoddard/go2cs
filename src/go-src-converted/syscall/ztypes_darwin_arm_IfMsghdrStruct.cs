//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
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
                this.Addrs = default;
                this.Flags = default;
                this.Index = default;
                this.Pad_cgo_0 = default;
                this.Data = default;
            }

            public IfMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, int Addrs = default, int Flags = default, ushort Index = default, array<byte> Pad_cgo_0 = default, IfData Data = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Index = Index;
                this.Pad_cgo_0 = Pad_cgo_0;
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
            return new IfMsghdr(value.Msglen, value.Version, value.Type, value.Addrs, value.Flags, value.Index, value.Pad_cgo_0, value.Data);
        }
    }
}