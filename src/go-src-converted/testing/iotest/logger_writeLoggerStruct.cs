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
using io = go.io_package;
using log = go.log_package;
using go;

namespace go {
namespace testing
{
    public static partial class iotest_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct writeLogger
        {
            // Constructors
            public writeLogger(NilType _)
            {
                this.prefix = default;
                this.w = default;
            }

            public writeLogger(@string prefix = default, io.Writer w = default)
            {
                this.prefix = prefix;
                this.w = w;
            }

            // Enable comparisons between nil and writeLogger struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(writeLogger value, NilType nil) => value.Equals(default(writeLogger));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(writeLogger value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, writeLogger value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, writeLogger value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator writeLogger(NilType nil) => default(writeLogger);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static writeLogger writeLogger_cast(dynamic value)
        {
            return new writeLogger(value.prefix, value.w);
        }
    }
}}