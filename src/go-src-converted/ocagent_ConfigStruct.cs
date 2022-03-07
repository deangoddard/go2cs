//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
                this.Start = default;
                this.Host = default;
                this.Process = default;
                this.Client = default;
                this.Service = default;
                this.Address = default;
                this.Rate = default;
            }

            public Config(time.Time Start = default, @string Host = default, uint Process = default, ref ptr<http.Client> Client = default, @string Service = default, @string Address = default, time.Duration Rate = default)
            {
                this.Start = Start;
                this.Host = Host;
                this.Process = Process;
                this.Client = Client;
                this.Service = Service;
                this.Address = Address;
                this.Rate = Rate;
            }

            // Enable comparisons between nil and Config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Config value, NilType nil) => value.Equals(default(Config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Config(NilType nil) => default(Config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Config Config_cast(dynamic value)
        {
            return new Config(value.Start, value.Host, value.Process, ref value.Client, value.Service, value.Address, value.Rate);
        }
    }
}}}}}}}