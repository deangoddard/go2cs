//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:34 UTC
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
        public partial struct TpacketAuxdata
        {
            // Constructors
            public TpacketAuxdata(NilType _)
            {
                this.Status = default;
                this.Len = default;
                this.Snaplen = default;
                this.Mac = default;
                this.Net = default;
                this.Vlan_tci = default;
                this.Vlan_tpid = default;
            }

            public TpacketAuxdata(uint Status = default, uint Len = default, uint Snaplen = default, ushort Mac = default, ushort Net = default, ushort Vlan_tci = default, ushort Vlan_tpid = default)
            {
                this.Status = Status;
                this.Len = Len;
                this.Snaplen = Snaplen;
                this.Mac = Mac;
                this.Net = Net;
                this.Vlan_tci = Vlan_tci;
                this.Vlan_tpid = Vlan_tpid;
            }

            // Enable comparisons between nil and TpacketAuxdata struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TpacketAuxdata value, NilType nil) => value.Equals(default(TpacketAuxdata));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TpacketAuxdata value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TpacketAuxdata value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TpacketAuxdata value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TpacketAuxdata(NilType nil) => default(TpacketAuxdata);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TpacketAuxdata TpacketAuxdata_cast(dynamic value)
        {
            return new TpacketAuxdata(value.Status, value.Len, value.Snaplen, value.Mac, value.Net, value.Vlan_tci, value.Vlan_tpid);
        }
    }
}}}}}}