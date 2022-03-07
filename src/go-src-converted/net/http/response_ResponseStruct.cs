//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:22:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Response
        {
            // Constructors
            public Response(NilType _)
            {
                this.Status = default;
                this.StatusCode = default;
                this.Proto = default;
                this.ProtoMajor = default;
                this.ProtoMinor = default;
                this.Header = default;
                this.Body = default;
                this.ContentLength = default;
                this.TransferEncoding = default;
                this.Close = default;
                this.Uncompressed = default;
                this.Trailer = default;
                this.Request = default;
                this.TLS = default;
            }

            public Response(@string Status = default, nint StatusCode = default, @string Proto = default, nint ProtoMajor = default, nint ProtoMinor = default, Header Header = default, io.ReadCloser Body = default, long ContentLength = default, slice<@string> TransferEncoding = default, bool Close = default, bool Uncompressed = default, Header Trailer = default, ref ptr<Request> Request = default, ref ptr<tls.ConnectionState> TLS = default)
            {
                this.Status = Status;
                this.StatusCode = StatusCode;
                this.Proto = Proto;
                this.ProtoMajor = ProtoMajor;
                this.ProtoMinor = ProtoMinor;
                this.Header = Header;
                this.Body = Body;
                this.ContentLength = ContentLength;
                this.TransferEncoding = TransferEncoding;
                this.Close = Close;
                this.Uncompressed = Uncompressed;
                this.Trailer = Trailer;
                this.Request = Request;
                this.TLS = TLS;
            }

            // Enable comparisons between nil and Response struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Response value, NilType nil) => value.Equals(default(Response));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Response value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Response value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Response value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Response(NilType nil) => default(Response);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Response Response_cast(dynamic value)
        {
            return new Response(value.Status, value.StatusCode, value.Proto, value.ProtoMajor, value.ProtoMinor, value.Header, value.Body, value.ContentLength, value.TransferEncoding, value.Close, value.Uncompressed, value.Trailer, ref value.Request, ref value.TLS);
        }
    }
}}