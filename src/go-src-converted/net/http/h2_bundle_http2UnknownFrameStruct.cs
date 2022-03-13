//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using hpack = go.golang.org.x.net.http2.hpack_package;
using idna = go.golang.org.x.net.idna_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(http2FrameHeader))]
        private partial struct http2UnknownFrame
        {
            // http2FrameHeader structure promotion - sourced from value copy
            private readonly ptr<http2FrameHeader> m_http2FrameHeaderRef;

            private ref http2FrameHeader http2FrameHeader_val => ref m_http2FrameHeaderRef.Value;

            public ref bool valid => ref m_http2FrameHeaderRef.Value.valid;

            public ref http2FrameType Type => ref m_http2FrameHeaderRef.Value.Type;

            public ref http2Flags Flags => ref m_http2FrameHeaderRef.Value.Flags;

            public ref uint Length => ref m_http2FrameHeaderRef.Value.Length;

            public ref uint StreamID => ref m_http2FrameHeaderRef.Value.StreamID;

            // Constructors
            public http2UnknownFrame(NilType _)
            {
                this.m_http2FrameHeaderRef = new ptr<http2FrameHeader>(new http2FrameHeader(nil));
                this.p = default;
            }

            public http2UnknownFrame(http2FrameHeader http2FrameHeader = default, slice<byte> p = default)
            {
                this.m_http2FrameHeaderRef = new ptr<http2FrameHeader>(http2FrameHeader);
                this.p = p;
            }

            // Enable comparisons between nil and http2UnknownFrame struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2UnknownFrame value, NilType nil) => value.Equals(default(http2UnknownFrame));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2UnknownFrame value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2UnknownFrame value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2UnknownFrame value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2UnknownFrame(NilType nil) => default(http2UnknownFrame);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static http2UnknownFrame http2UnknownFrame_cast(dynamic value)
        {
            return new http2UnknownFrame(value.http2FrameHeader, value.p);
        }
    }
}}