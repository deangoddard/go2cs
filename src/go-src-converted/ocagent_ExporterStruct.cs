//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using context = go.context_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using http = go.net.http_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sync = go.sync_package;
using time = go.time_package;
using @event = go.golang.org.x.tools.@internal.@event_package;
using core = go.golang.org.x.tools.@internal.@event.core_package;
using export = go.golang.org.x.tools.@internal.@event.export_package;
using metric = go.golang.org.x.tools.@internal.@event.export.metric_package;
using wire = go.golang.org.x.tools.@internal.@event.export.ocagent.wire_package;
using keys = go.golang.org.x.tools.@internal.@event.keys_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event {
namespace export
{
    public static partial class ocagent_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Exporter
        {
            // Constructors
            public Exporter(NilType _)
            {
                this.mu = default;
                this.config = default;
                this.spans = default;
                this.metrics = default;
            }

            public Exporter(sync.Mutex mu = default, Config config = default, slice<ptr<export.Span>> spans = default, slice<metric.Data> metrics = default)
            {
                this.mu = mu;
                this.config = config;
                this.spans = spans;
                this.metrics = metrics;
            }

            // Enable comparisons between nil and Exporter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Exporter value, NilType nil) => value.Equals(default(Exporter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Exporter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Exporter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Exporter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Exporter(NilType nil) => default(Exporter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Exporter Exporter_cast(dynamic value)
        {
            return new Exporter(value.mu, value.config, value.spans, value.metrics);
        }
    }
}}}}}}}