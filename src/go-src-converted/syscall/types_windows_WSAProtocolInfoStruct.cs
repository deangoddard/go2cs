//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:02:04 UTC
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
        public partial struct WSAProtocolInfo
        {
            // Constructors
            public WSAProtocolInfo(NilType _)
            {
                this.ServiceFlags1 = default;
                this.ServiceFlags2 = default;
                this.ServiceFlags3 = default;
                this.ServiceFlags4 = default;
                this.ProviderFlags = default;
                this.ProviderId = default;
                this.CatalogEntryId = default;
                this.ProtocolChain = default;
                this.Version = default;
                this.AddressFamily = default;
                this.MaxSockAddr = default;
                this.MinSockAddr = default;
                this.SocketType = default;
                this.Protocol = default;
                this.ProtocolMaxOffset = default;
                this.NetworkByteOrder = default;
                this.SecurityScheme = default;
                this.MessageSize = default;
                this.ProviderReserved = default;
                this.ProtocolName = default;
            }

            public WSAProtocolInfo(uint ServiceFlags1 = default, uint ServiceFlags2 = default, uint ServiceFlags3 = default, uint ServiceFlags4 = default, uint ProviderFlags = default, GUID ProviderId = default, uint CatalogEntryId = default, WSAProtocolChain ProtocolChain = default, int Version = default, int AddressFamily = default, int MaxSockAddr = default, int MinSockAddr = default, int SocketType = default, int Protocol = default, int ProtocolMaxOffset = default, int NetworkByteOrder = default, int SecurityScheme = default, uint MessageSize = default, uint ProviderReserved = default, array<ushort> ProtocolName = default)
            {
                this.ServiceFlags1 = ServiceFlags1;
                this.ServiceFlags2 = ServiceFlags2;
                this.ServiceFlags3 = ServiceFlags3;
                this.ServiceFlags4 = ServiceFlags4;
                this.ProviderFlags = ProviderFlags;
                this.ProviderId = ProviderId;
                this.CatalogEntryId = CatalogEntryId;
                this.ProtocolChain = ProtocolChain;
                this.Version = Version;
                this.AddressFamily = AddressFamily;
                this.MaxSockAddr = MaxSockAddr;
                this.MinSockAddr = MinSockAddr;
                this.SocketType = SocketType;
                this.Protocol = Protocol;
                this.ProtocolMaxOffset = ProtocolMaxOffset;
                this.NetworkByteOrder = NetworkByteOrder;
                this.SecurityScheme = SecurityScheme;
                this.MessageSize = MessageSize;
                this.ProviderReserved = ProviderReserved;
                this.ProtocolName = ProtocolName;
            }

            // Enable comparisons between nil and WSAProtocolInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(WSAProtocolInfo value, NilType nil) => value.Equals(default(WSAProtocolInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(WSAProtocolInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, WSAProtocolInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, WSAProtocolInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator WSAProtocolInfo(NilType nil) => default(WSAProtocolInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static WSAProtocolInfo WSAProtocolInfo_cast(dynamic value)
        {
            return new WSAProtocolInfo(value.ServiceFlags1, value.ServiceFlags2, value.ServiceFlags3, value.ServiceFlags4, value.ProviderFlags, value.ProviderId, value.CatalogEntryId, value.ProtocolChain, value.Version, value.AddressFamily, value.MaxSockAddr, value.MinSockAddr, value.SocketType, value.Protocol, value.ProtocolMaxOffset, value.NetworkByteOrder, value.SecurityScheme, value.MessageSize, value.ProviderReserved, value.ProtocolName);
        }
    }
}