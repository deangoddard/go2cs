//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
using url = go.net.url_package;
using os = go.os_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httplex = go.golang_org.x.net.lex.httplex_package;
using proxy = go.golang_org.x.net.proxy_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct connLRU
        {
            // Constructors
            public connLRU(NilType _)
            {
                this.ll = default;
                this.m = default;
            }

            public connLRU(ref ptr<list.List> ll = default, map<ref persistConn, ref list.Element> m = default)
            {
                this.ll = ll;
                this.m = m;
            }

            // Enable comparisons between nil and connLRU struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(connLRU value, NilType nil) => value.Equals(default(connLRU));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(connLRU value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, connLRU value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, connLRU value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator connLRU(NilType nil) => default(connLRU);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static connLRU connLRU_cast(dynamic value)
        {
            return new connLRU(ref value.ll, value.m);
        }
    }
}}