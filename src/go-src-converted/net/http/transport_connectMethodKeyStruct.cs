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
        private partial struct connectMethodKey
        {
            // Constructors
            public connectMethodKey(NilType _)
            {
                this.proxy = default;
                this.scheme = default;
                this.addr = default;
                this.onlyH1 = default;
            }

            public connectMethodKey(@string proxy = default, @string scheme = default, @string addr = default, bool onlyH1 = default)
            {
                this.proxy = proxy;
                this.scheme = scheme;
                this.addr = addr;
                this.onlyH1 = onlyH1;
            }

            // Enable comparisons between nil and connectMethodKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(connectMethodKey value, NilType nil) => value.Equals(default(connectMethodKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(connectMethodKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, connectMethodKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, connectMethodKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator connectMethodKey(NilType nil) => default(connectMethodKey);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static connectMethodKey connectMethodKey_cast(dynamic value)
        {
            return new connectMethodKey(value.proxy, value.scheme, value.addr, value.onlyH1);
        }
    }
}}