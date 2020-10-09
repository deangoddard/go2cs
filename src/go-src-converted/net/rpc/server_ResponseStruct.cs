//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using gob = go.encoding.gob_package;
using errors = go.errors_package;
using token = go.go.token_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Response
        {
            // Constructors
            public Response(NilType _)
            {
                this.ServiceMethod = default;
                this.Seq = default;
                this.Error = default;
                this.next = default;
            }

            public Response(@string ServiceMethod = default, ulong Seq = default, @string Error = default, ref ptr<Response> next = default)
            {
                this.ServiceMethod = ServiceMethod;
                this.Seq = Seq;
                this.Error = Error;
                this.next = next;
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
            return new Response(value.ServiceMethod, value.Seq, value.Error, ref value.next);
        }
    }
}}