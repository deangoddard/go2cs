//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using fmt = go.fmt_package;
using io = go.io_package;
using sync = go.sync_package;
using @event = go.golang.org.x.tools.@internal.@event_package;
using core = go.golang.org.x.tools.@internal.@event.core_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class export_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct logWriter
        {
            // Constructors
            public logWriter(NilType _)
            {
                this.mu = default;
                this.printer = default;
                this.writer = default;
                this.onlyErrors = default;
            }

            public logWriter(sync.Mutex mu = default, Printer printer = default, io.Writer writer = default, bool onlyErrors = default)
            {
                this.mu = mu;
                this.printer = printer;
                this.writer = writer;
                this.onlyErrors = onlyErrors;
            }

            // Enable comparisons between nil and logWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(logWriter value, NilType nil) => value.Equals(default(logWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(logWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, logWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, logWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator logWriter(NilType nil) => default(logWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static logWriter logWriter_cast(dynamic value)
        {
            return new logWriter(value.mu, value.printer, value.writer, value.onlyErrors);
        }
    }
}}}}}}