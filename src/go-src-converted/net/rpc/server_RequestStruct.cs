//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:36:36 UTC
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
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace net
{
    public static partial class rpc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Request
        {
            // Constructors
            public Request(NilType _)
            {
                this.ServiceMethod = default;
                this.Seq = default;
                this.next = default;
            }

            public Request(@string ServiceMethod = default, ulong Seq = default, ref ptr<Request> next = default)
            {
                this.ServiceMethod = ServiceMethod;
                this.Seq = Seq;
                this.next = next;
            }

            // Enable comparisons between nil and Request struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Request value, NilType nil) => value.Equals(default(Request));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Request value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Request value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Request value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Request(NilType nil) => default(Request);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Request Request_cast(dynamic value)
        {
            return new Request(value.ServiceMethod, value.Seq, ref value.next);
        }
    }
}}