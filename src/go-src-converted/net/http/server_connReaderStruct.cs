//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:02 UTC
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
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct connReader
        {
            // Constructors
            public connReader(NilType _)
            {
                this.conn = default;
                this.mu = default;
                this.hasByte = default;
                this.byteBuf = default;
                this.cond = default;
                this.inRead = default;
                this.aborted = default;
                this.remain = default;
            }

            public connReader(ref ptr<conn> conn = default, sync.Mutex mu = default, bool hasByte = default, array<byte> byteBuf = default, ref ptr<sync.Cond> cond = default, bool inRead = default, bool aborted = default, long remain = default)
            {
                this.conn = conn;
                this.mu = mu;
                this.hasByte = hasByte;
                this.byteBuf = byteBuf;
                this.cond = cond;
                this.inRead = inRead;
                this.aborted = aborted;
                this.remain = remain;
            }

            // Enable comparisons between nil and connReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(connReader value, NilType nil) => value.Equals(default(connReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(connReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, connReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, connReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator connReader(NilType nil) => default(connReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static connReader connReader_cast(dynamic value)
        {
            return new connReader(ref value.conn, value.mu, value.hasByte, value.byteBuf, ref value.cond, value.inRead, value.aborted, value.remain);
        }
    }
}}