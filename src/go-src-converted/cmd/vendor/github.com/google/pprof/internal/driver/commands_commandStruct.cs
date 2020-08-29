//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using exec = go.os.exec_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using report = go.github.com.google.pprof.@internal.report_package;
using svg = go.github.com.google.pprof.third_party.svg_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct command
        {
            // Constructors
            public command(NilType _)
            {
                this.format = default;
                this.postProcess = default;
                this.visualizer = default;
                this.hasParam = default;
                this.description = default;
                this.usage = default;
            }

            public command(long format = default, PostProcessor postProcess = default, PostProcessor visualizer = default, bool hasParam = default, @string description = default, @string usage = default)
            {
                this.format = format;
                this.postProcess = postProcess;
                this.visualizer = visualizer;
                this.hasParam = hasParam;
                this.description = description;
                this.usage = usage;
            }

            // Enable comparisons between nil and command struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(command value, NilType nil) => value.Equals(default(command));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(command value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, command value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, command value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator command(NilType nil) => default(command);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static command command_cast(dynamic value)
        {
            return new command(value.format, value.postProcess, value.visualizer, value.hasParam, value.description, value.usage);
        }
    }
}}}}}}}