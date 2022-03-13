//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using gob = go.encoding.gob_package;
using errors = go.errors_package;
using token = go.go.token_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct gobServerCodec
        {
            // Constructors
            public gobServerCodec(NilType _)
            {
                this.rwc = default;
                this.dec = default;
                this.enc = default;
                this.encBuf = default;
                this.closed = default;
            }

            public gobServerCodec(io.ReadWriteCloser rwc = default, ref ptr<gob.Decoder> dec = default, ref ptr<gob.Encoder> enc = default, ref ptr<bufio.Writer> encBuf = default, bool closed = default)
            {
                this.rwc = rwc;
                this.dec = dec;
                this.enc = enc;
                this.encBuf = encBuf;
                this.closed = closed;
            }

            // Enable comparisons between nil and gobServerCodec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobServerCodec value, NilType nil) => value.Equals(default(gobServerCodec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobServerCodec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobServerCodec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobServerCodec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gobServerCodec(NilType nil) => default(gobServerCodec);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static gobServerCodec gobServerCodec_cast(dynamic value)
        {
            return new gobServerCodec(value.rwc, ref value.dec, ref value.enc, ref value.encBuf, value.closed);
        }
    }
}}