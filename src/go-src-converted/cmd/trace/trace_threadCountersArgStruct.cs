//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using traceviewer = go.cmd.@internal.traceviewer_package;
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
        private partial struct threadCountersArg
        {
            // Constructors
            public threadCountersArg(NilType _)
            {
                this.Running = default;
                this.InSyscall = default;
            }

            public threadCountersArg(long Running = default, long InSyscall = default)
            {
                this.Running = Running;
                this.InSyscall = InSyscall;
            }

            // Enable comparisons between nil and threadCountersArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(threadCountersArg value, NilType nil) => value.Equals(default(threadCountersArg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(threadCountersArg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, threadCountersArg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, threadCountersArg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator threadCountersArg(NilType nil) => default(threadCountersArg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static threadCountersArg threadCountersArg_cast(dynamic value)
        {
            return new threadCountersArg(value.Running, value.InSyscall);
        }
    }
}