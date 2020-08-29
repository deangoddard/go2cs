//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using context = go.context_package;
using rand = go.crypto.rand_package;
using tls = go.crypto.tls_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using math = go.math_package;
using mathrand = go.math.rand_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using hpack = go.golang_org.x.net.http2.hpack_package;
using idna = go.golang_org.x.net.idna_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2HeadersFrameParam
        {
            // Constructors
            public http2HeadersFrameParam(NilType _)
            {
                this.StreamID = default;
                this.BlockFragment = default;
                this.EndStream = default;
                this.EndHeaders = default;
                this.PadLength = default;
                this.Priority = default;
            }

            public http2HeadersFrameParam(uint StreamID = default, slice<byte> BlockFragment = default, bool EndStream = default, bool EndHeaders = default, byte PadLength = default, http2PriorityParam Priority = default)
            {
                this.StreamID = StreamID;
                this.BlockFragment = BlockFragment;
                this.EndStream = EndStream;
                this.EndHeaders = EndHeaders;
                this.PadLength = PadLength;
                this.Priority = Priority;
            }

            // Enable comparisons between nil and http2HeadersFrameParam struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2HeadersFrameParam value, NilType nil) => value.Equals(default(http2HeadersFrameParam));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2HeadersFrameParam value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2HeadersFrameParam value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2HeadersFrameParam value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2HeadersFrameParam(NilType nil) => default(http2HeadersFrameParam);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2HeadersFrameParam http2HeadersFrameParam_cast(dynamic value)
        {
            return new http2HeadersFrameParam(value.StreamID, value.BlockFragment, value.EndStream, value.EndHeaders, value.PadLength, value.Priority);
        }
    }
}}