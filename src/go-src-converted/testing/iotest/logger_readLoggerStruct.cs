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
        private partial struct readLogger
        {
            // Constructors
            public readLogger(NilType _)
            {
                this.prefix = default;
                this.r = default;
            }

            public readLogger(@string prefix = default, io.Reader r = default)
            {
                this.prefix = prefix;
                this.r = r;
            }

            // Enable comparisons between nil and readLogger struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(readLogger value, NilType nil) => value.Equals(default(readLogger));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(readLogger value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, readLogger value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, readLogger value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator readLogger(NilType nil) => default(readLogger);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static readLogger readLogger_cast(dynamic value)
        {
            return new readLogger(value.prefix, value.r);
        }
    }
}}