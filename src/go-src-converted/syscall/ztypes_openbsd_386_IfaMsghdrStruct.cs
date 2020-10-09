//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:34 UTC
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
        public partial struct IfaMsghdr
        {
            // Constructors
            public IfaMsghdr(NilType _)
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
                this.Metric = default;
            }

            public IfaMsghdr(ushort Msglen = default, byte Version = default, byte Type = default, ushort Hdrlen = default, ushort Index = default, ushort Tableid = default, byte Pad1 = default, byte Pad2 = default, int Addrs = default, int Flags = default, int Metric = default)
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
                this.Metric = Metric;
            }

            // Enable comparisons between nil and IfaMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IfaMsghdr value, NilType nil) => value.Equals(default(IfaMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IfaMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IfaMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IfaMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IfaMsghdr(NilType nil) => default(IfaMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static IfaMsghdr IfaMsghdr_cast(dynamic value)
        {
            return new IfaMsghdr(value.Msglen, value.Version, value.Type, value.Hdrlen, value.Index, value.Tableid, value.Pad1, value.Pad2, value.Addrs, value.Flags, value.Metric);
        }
    }
}