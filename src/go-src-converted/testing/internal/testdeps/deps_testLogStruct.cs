//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using testlog = go.@internal.testlog_package;
using io = go.io_package;
using regexp = go.regexp_package;
using pprof = go.runtime.pprof_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace testing {
namespace @internal
{
    public static partial class testdeps_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct testLog
        {
            // Constructors
            public testLog(NilType _)
            {
                this.mu = default;
                this.w = default;
                this.set = default;
            }

            public testLog(sync.Mutex mu = default, ref ptr<bufio.Writer> w = default, bool set = default)
            {
                this.mu = mu;
                this.w = w;
                this.set = set;
            }

            // Enable comparisons between nil and testLog struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testLog value, NilType nil) => value.Equals(default(testLog));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testLog value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testLog value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testLog value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testLog(NilType nil) => default(testLog);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static testLog testLog_cast(dynamic value)
        {
            return new testLog(value.mu, ref value.w, value.set);
        }
    }
}}}