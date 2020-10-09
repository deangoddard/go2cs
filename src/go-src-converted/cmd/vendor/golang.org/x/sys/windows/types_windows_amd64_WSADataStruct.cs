//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:59 UTC
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
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct WSAData
        {
            // Constructors
            public WSAData(NilType _)
            {
                this.Version = default;
                this.HighVersion = default;
                this.MaxSockets = default;
                this.MaxUdpDg = default;
                this.VendorInfo = default;
                this.Description = default;
                this.SystemStatus = default;
            }

            public WSAData(ushort Version = default, ushort HighVersion = default, ushort MaxSockets = default, ushort MaxUdpDg = default, ref ptr<byte> VendorInfo = default, array<byte> Description = default, array<byte> SystemStatus = default)
            {
                this.Version = Version;
                this.HighVersion = HighVersion;
                this.MaxSockets = MaxSockets;
                this.MaxUdpDg = MaxUdpDg;
                this.VendorInfo = VendorInfo;
                this.Description = Description;
                this.SystemStatus = SystemStatus;
            }

            // Enable comparisons between nil and WSAData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(WSAData value, NilType nil) => value.Equals(default(WSAData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(WSAData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, WSAData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, WSAData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator WSAData(NilType nil) => default(WSAData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static WSAData WSAData_cast(dynamic value)
        {
            return new WSAData(value.Version, value.HighVersion, value.MaxSockets, value.MaxUdpDg, ref value.VendorInfo, value.Description, value.SystemStatus);
        }
    }
}}}}}}