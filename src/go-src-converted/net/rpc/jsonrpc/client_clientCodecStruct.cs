//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        private partial struct clientCodec
        {
            // Constructors
            public clientCodec(NilType _)
            {
                this.dec = default;
                this.enc = default;
                this.c = default;
                this.req = default;
                this.resp = default;
                this.mutex = default;
                this.pending = default;
            }

            public clientCodec(ref ptr<json.Decoder> dec = default, ref ptr<json.Encoder> enc = default, io.Closer c = default, clientRequest req = default, clientResponse resp = default, sync.Mutex mutex = default, map<ulong, @string> pending = default)
            {
                this.dec = dec;
                this.enc = enc;
                this.c = c;
                this.req = req;
                this.resp = resp;
                this.mutex = mutex;
                this.pending = pending;
            }

            // Enable comparisons between nil and clientCodec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(clientCodec value, NilType nil) => value.Equals(default(clientCodec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(clientCodec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, clientCodec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, clientCodec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator clientCodec(NilType nil) => default(clientCodec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static clientCodec clientCodec_cast(dynamic value)
        {
            return new clientCodec(ref value.dec, ref value.enc, value.c, value.req, value.resp, value.mutex, value.pending);
        }
    }
}}}