//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using binutils = go.github.com.google.pprof.@internal.binutils_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using symbolizer = go.github.com.google.pprof.@internal.symbolizer_package;
using transport = go.github.com.google.pprof.@internal.transport_package;
using go;

#nullable enable

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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct stdUI
        {
            // Constructors
            public stdUI(NilType _)
            {
                this.r = default;
            }

            public stdUI(ref ptr<bufio.Reader> r = default)
            {
                this.r = r;
            }

            // Enable comparisons between nil and stdUI struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stdUI value, NilType nil) => value.Equals(default(stdUI));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stdUI value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stdUI value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stdUI value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stdUI(NilType nil) => default(stdUI);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static stdUI stdUI_cast(dynamic value)
        {
            return new stdUI(ref value.r);
        }
    }
}}}}}}}