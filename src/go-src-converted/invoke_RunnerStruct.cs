//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using exec = go.os.exec_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using @event = go.golang.org.x.tools.@internal.@event_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal
{
    public static partial class gocommand_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Runner
        {
            // Constructors
            public Runner(NilType _)
            {
                this.loadMu = default;
                this.serializeLoads = default;
            }

            public Runner(sync.Mutex loadMu = default, nint serializeLoads = default)
            {
                this.loadMu = loadMu;
                this.serializeLoads = serializeLoads;
            }

            // Enable comparisons between nil and Runner struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Runner value, NilType nil) => value.Equals(default(Runner));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Runner value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Runner value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Runner value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Runner(NilType nil) => default(Runner);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Runner Runner_cast(dynamic value)
        {
            return new Runner(value.loadMu, value.serializeLoads);
        }
    }
}}}}}