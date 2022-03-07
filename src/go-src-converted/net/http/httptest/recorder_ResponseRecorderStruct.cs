//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using http = go.net.http_package;
using textproto = go.net.textproto_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace http
{
    public static partial class httptest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ResponseRecorder
        {
            // Constructors
            public ResponseRecorder(NilType _)
            {
                this.Code = default;
                this.HeaderMap = default;
                this.Body = default;
                this.Flushed = default;
                this.result = default;
                this.snapHeader = default;
                this.wroteHeader = default;
            }

            public ResponseRecorder(nint Code = default, http.Header HeaderMap = default, ref ptr<bytes.Buffer> Body = default, bool Flushed = default, ref ptr<http.Response> result = default, http.Header snapHeader = default, bool wroteHeader = default)
            {
                this.Code = Code;
                this.HeaderMap = HeaderMap;
                this.Body = Body;
                this.Flushed = Flushed;
                this.result = result;
                this.snapHeader = snapHeader;
                this.wroteHeader = wroteHeader;
            }

            // Enable comparisons between nil and ResponseRecorder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ResponseRecorder value, NilType nil) => value.Equals(default(ResponseRecorder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ResponseRecorder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ResponseRecorder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ResponseRecorder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ResponseRecorder(NilType nil) => default(ResponseRecorder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ResponseRecorder ResponseRecorder_cast(dynamic value)
        {
            return new ResponseRecorder(value.Code, value.HeaderMap, ref value.Body, value.Flushed, ref value.result, value.snapHeader, value.wroteHeader);
        }
    }
}}}