//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using binutils = go.github.com.google.pprof.@internal.binutils_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using symbolizer = go.github.com.google.pprof.@internal.symbolizer_package;
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
        private partial struct goFlags
        {
            // Constructors
            public goFlags(NilType _)
            {
            }
            // Enable comparisons between nil and goFlags struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(goFlags value, NilType nil) => value.Equals(default(goFlags));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(goFlags value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, goFlags value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, goFlags value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator goFlags(NilType nil) => default(goFlags);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static goFlags goFlags_cast(dynamic value)
        {
            return new goFlags();
        }
    }
}}}}}}}