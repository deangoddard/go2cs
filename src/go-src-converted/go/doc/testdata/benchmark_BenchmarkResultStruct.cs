//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using flag = go.flag_package;
using fmt = go.fmt_package;
using os = go.os_package;
using runtime = go.runtime_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BenchmarkResult
        {
            // Constructors
            public BenchmarkResult(NilType _)
            {
                this.N = default;
                this.T = default;
                this.Bytes = default;
            }

            public BenchmarkResult(nint N = default, time.Duration T = default, long Bytes = default)
            {
                this.N = N;
                this.T = T;
                this.Bytes = Bytes;
            }

            // Enable comparisons between nil and BenchmarkResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BenchmarkResult value, NilType nil) => value.Equals(default(BenchmarkResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BenchmarkResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BenchmarkResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BenchmarkResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BenchmarkResult(NilType nil) => default(BenchmarkResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BenchmarkResult BenchmarkResult_cast(dynamic value)
        {
            return new BenchmarkResult(value.N, value.T, value.Bytes);
        }
    }
}}