//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IfmaMsghdr2
        {
            // Constructors
            public IfmaMsghdr2(NilType _)
            {
                this.Msglen = default;
                this.Version = default;
                this.Type = default;
                this.Addrs = default;
                this.Flags = default;
                this.Index = default;
                this.Pad_cgo_0 = default;
                this.Refcount = default;
            }

            public IfmaMsghdr2(ushort Msglen = default, byte Version = default, byte Type = default, int Addrs = default, int Flags = default, ushort Index = default, array<byte> Pad_cgo_0 = default, int Refcount = default)
            {
                this.Msglen = Msglen;
                this.Version = Version;
                this.Type = Type;
                this.Addrs = Addrs;
                this.Flags = Flags;
                this.Index = Index;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Refcount = Refcount;
            }

            // Enable comparisons between nil and IfmaMsghdr2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfmaMsghdr2 value, NilType nil) => value.Equals(default(IfmaMsghdr2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfmaMsghdr2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfmaMsghdr2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfmaMsghdr2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfmaMsghdr2(NilType nil) => default(IfmaMsghdr2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfmaMsghdr2 IfmaMsghdr2_cast(dynamic value)
        {
            return new IfmaMsghdr2(value.Msglen, value.Version, value.Type, value.Addrs, value.Flags, value.Index, value.Pad_cgo_0, value.Refcount);
        }
    }
}