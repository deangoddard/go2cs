//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:34:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using url = go.net.url_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httputil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct maxLatencyWriter
        {
            // Constructors
            public maxLatencyWriter(NilType _)
            {
                this.dst = default;
                this.latency = default;
                this.mu = default;
                this.done = default;
            }

            public maxLatencyWriter(writeFlusher dst = default, time.Duration latency = default, sync.Mutex mu = default, channel<bool> done = default)
            {
                this.dst = dst;
                this.latency = latency;
                this.mu = mu;
                this.done = done;
            }

            // Enable comparisons between nil and maxLatencyWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(maxLatencyWriter value, NilType nil) => value.Equals(default(maxLatencyWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(maxLatencyWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, maxLatencyWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, maxLatencyWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator maxLatencyWriter(NilType nil) => default(maxLatencyWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static maxLatencyWriter maxLatencyWriter_cast(dynamic value)
        {
            return new maxLatencyWriter(value.dst, value.latency, value.mu, value.done);
        }
    }
}}}