//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:26:39 UTC
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
        public partial struct NetlinkRouteRequest
        {
            // Constructors
            public NetlinkRouteRequest(NilType _)
            {
                this.Header = default;
                this.Data = default;
            }

            public NetlinkRouteRequest(NlMsghdr Header = default, RtGenmsg Data = default)
            {
                this.Header = Header;
                this.Data = Data;
            }

            // Enable comparisons between nil and NetlinkRouteRequest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NetlinkRouteRequest value, NilType nil) => value.Equals(default(NetlinkRouteRequest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NetlinkRouteRequest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NetlinkRouteRequest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NetlinkRouteRequest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NetlinkRouteRequest(NilType nil) => default(NetlinkRouteRequest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NetlinkRouteRequest NetlinkRouteRequest_cast(dynamic value)
        {
            return new NetlinkRouteRequest(value.Header, value.Data);
        }
    }
}