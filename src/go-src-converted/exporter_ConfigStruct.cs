//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using sync = go.sync_package;
using time = go.time_package;
using @event = go.golang.org.x.tools.@internal.@event_package;
using core = go.golang.org.x.tools.@internal.@event.core_package;
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
    public static partial class metric_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
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
            return new Config();
        }
    }
}}}}}}}