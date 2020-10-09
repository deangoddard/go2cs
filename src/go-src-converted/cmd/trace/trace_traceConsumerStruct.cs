//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:53:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using trace = go.@internal.trace_package;
using io = go.io_package;
using log = go.log_package;
using math = go.math_package;
using http = go.net.http_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using debug = go.runtime.debug_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct traceConsumer
        {
            // Constructors
            public traceConsumer(NilType _)
            {
                this.consumeTimeUnit = default;
                this.consumeViewerEvent = default;
                this.consumeViewerFrame = default;
                this.flush = default;
            }

            public traceConsumer(Action<@string> consumeTimeUnit = default, Action<ptr<ViewerEvent>, bool> consumeViewerEvent = default, Action<@string, ViewerFrame> consumeViewerFrame = default, Action flush = default)
            {
                this.consumeTimeUnit = consumeTimeUnit;
                this.consumeViewerEvent = consumeViewerEvent;
                this.consumeViewerFrame = consumeViewerFrame;
                this.flush = flush;
            }

            // Enable comparisons between nil and traceConsumer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(traceConsumer value, NilType nil) => value.Equals(default(traceConsumer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(traceConsumer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, traceConsumer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, traceConsumer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator traceConsumer(NilType nil) => default(traceConsumer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static traceConsumer traceConsumer_cast(dynamic value)
        {
            return new traceConsumer(value.consumeTimeUnit, value.consumeViewerEvent, value.consumeViewerFrame, value.flush);
        }
    }
}