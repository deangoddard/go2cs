//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using rpc = go.net.rpc_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace rpc
{
    public static partial class jsonrpc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct clientRequest
        {
            // Constructors
            public clientRequest(NilType _)
            {
                this.Method = default;
                this.Id = default;
            }

            public clientRequest(@string Method = default, ulong Id = default)
            {
                this.Method = Method;
                this.Id = Id;
            }

            // Enable comparisons between nil and clientRequest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(clientRequest value, NilType nil) => value.Equals(default(clientRequest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(clientRequest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, clientRequest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, clientRequest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator clientRequest(NilType nil) => default(clientRequest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static clientRequest clientRequest_cast(dynamic value)
        {
            return new clientRequest(value.Method, value.Id);
        }
    }
}}}