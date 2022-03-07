//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using http = go.net.http_package;
using cgi = go.net.http.cgi_package;
using os = go.os_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace http
{
    public static partial class fcgi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct request
        {
            // Constructors
            public request(NilType _)
            {
                this.pw = default;
                this.reqId = default;
                this.@params = default;
                this.buf = default;
                this.rawParams = default;
                this.keepConn = default;
            }

            public request(ref ptr<io.PipeWriter> pw = default, ushort reqId = default, map<@string, @string> @params = default, array<byte> buf = default, slice<byte> rawParams = default, bool keepConn = default)
            {
                this.pw = pw;
                this.reqId = reqId;
                this.@params = @params;
                this.buf = buf;
                this.rawParams = rawParams;
                this.keepConn = keepConn;
            }

            // Enable comparisons between nil and request struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(request value, NilType nil) => value.Equals(default(request));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(request value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, request value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, request value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator request(NilType nil) => default(request);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static request request_cast(dynamic value)
        {
            return new request(ref value.pw, value.reqId, value.@params, value.buf, value.rawParams, value.keepConn);
        }
    }
}}}