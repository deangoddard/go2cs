//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using gzip = go.compress.gzip_package;
using list = go.container.list_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using ascii = go.net.http.@internal.ascii_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using httpproxy = go.golang.org.x.net.http.httpproxy_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct readWriteCloserBody
        {            
            [DebuggerStepperBoundary]
            static readWriteCloserBody()
            {
                Type targetType = typeof(readWriteCloserBody);
                MethodInfo extensionMethod;
            }

            // Constructors
            public readWriteCloserBody(NilType _)
            {
                this._ = default;
                this.br = default;
                this.ReadWriteCloser = default;
            }

            public readWriteCloserBody(incomparable _ = default, ref ptr<bufio.Reader> br = default, io.ReadWriteCloser ReadWriteCloser = default)
            {
                this._ = _;
                this.br = br;
                this.ReadWriteCloser = ReadWriteCloser;
            }

            // Enable comparisons between nil and readWriteCloserBody struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readWriteCloserBody value, NilType nil) => value.Equals(default(readWriteCloserBody));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readWriteCloserBody value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readWriteCloserBody value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readWriteCloserBody value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readWriteCloserBody(NilType nil) => default(readWriteCloserBody);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static readWriteCloserBody readWriteCloserBody_cast(dynamic value)
        {
            return new readWriteCloserBody(value._, ref value.br, value.ReadWriteCloser);
        }
    }
}}