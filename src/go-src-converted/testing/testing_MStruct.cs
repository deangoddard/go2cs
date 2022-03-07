//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using race = go.@internal.race_package;
using io = go.io_package;
using rand = go.math.rand_package;
using os = go.os_package;
using runtime = go.runtime_package;
using debug = go.runtime.debug_package;
using trace = go.runtime.trace_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct M
        {
            // Constructors
            public M(NilType _)
            {
                this.deps = default;
                this.tests = default;
                this.benchmarks = default;
                this.examples = default;
                this.timer = default;
                this.afterOnce = default;
                this.numRun = default;
                this.exitCode = default;
            }

            public M(testDeps deps = default, slice<InternalTest> tests = default, slice<InternalBenchmark> benchmarks = default, slice<InternalExample> examples = default, ref ptr<time.Timer> timer = default, sync.Once afterOnce = default, nint numRun = default, nint exitCode = default)
            {
                this.deps = deps;
                this.tests = tests;
                this.benchmarks = benchmarks;
                this.examples = examples;
                this.timer = timer;
                this.afterOnce = afterOnce;
                this.numRun = numRun;
                this.exitCode = exitCode;
            }

            // Enable comparisons between nil and M struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(M value, NilType nil) => value.Equals(default(M));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(M value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, M value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, M value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator M(NilType nil) => default(M);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static M M_cast(dynamic value)
        {
            return new M(value.deps, value.tests, value.benchmarks, value.examples, ref value.timer, value.afterOnce, value.numRun, value.exitCode);
        }
    }
}