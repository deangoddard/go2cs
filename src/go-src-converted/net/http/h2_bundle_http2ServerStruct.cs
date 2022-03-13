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
        private partial struct http2Server
        {
            // Constructors
            public http2Server(NilType _)
            {
                this.MaxHandlers = default;
                this.MaxConcurrentStreams = default;
                this.MaxReadFrameSize = default;
                this.PermitProhibitedCipherSuites = default;
                this.IdleTimeout = default;
                this.MaxUploadBufferPerConnection = default;
                this.MaxUploadBufferPerStream = default;
                this.NewWriteScheduler = default;
                this.state = default;
            }

            public http2Server(nint MaxHandlers = default, uint MaxConcurrentStreams = default, uint MaxReadFrameSize = default, bool PermitProhibitedCipherSuites = default, time.Duration IdleTimeout = default, int MaxUploadBufferPerConnection = default, int MaxUploadBufferPerStream = default, Func<http2WriteScheduler> NewWriteScheduler = default, ref ptr<http2serverInternalState> state = default)
            {
                this.MaxHandlers = MaxHandlers;
                this.MaxConcurrentStreams = MaxConcurrentStreams;
                this.MaxReadFrameSize = MaxReadFrameSize;
                this.PermitProhibitedCipherSuites = PermitProhibitedCipherSuites;
                this.IdleTimeout = IdleTimeout;
                this.MaxUploadBufferPerConnection = MaxUploadBufferPerConnection;
                this.MaxUploadBufferPerStream = MaxUploadBufferPerStream;
                this.NewWriteScheduler = NewWriteScheduler;
                this.state = state;
            }

            // Enable comparisons between nil and http2Server struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2Server value, NilType nil) => value.Equals(default(http2Server));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2Server value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2Server value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2Server value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2Server(NilType nil) => default(http2Server);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static http2Server http2Server_cast(dynamic value)
        {
            return new http2Server(value.MaxHandlers, value.MaxConcurrentStreams, value.MaxReadFrameSize, value.PermitProhibitedCipherSuites, value.IdleTimeout, value.MaxUploadBufferPerConnection, value.MaxUploadBufferPerStream, value.NewWriteScheduler, ref value.state);
        }
    }
}}