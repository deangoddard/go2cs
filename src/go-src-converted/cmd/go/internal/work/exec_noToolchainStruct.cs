//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using lazyregexp = go.@internal.lazyregexp_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using rand = go.math.rand_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using @base = go.cmd.go.@internal.@base_package;
using cache = go.cmd.go.@internal.cache_package;
using cfg = go.cmd.go.@internal.cfg_package;
using load = go.cmd.go.@internal.load_package;
using str = go.cmd.go.@internal.str_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class work_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noToolchain
        {
            // Constructors
            public noToolchain(NilType _)
            {
            }
            // Enable comparisons between nil and noToolchain struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noToolchain value, NilType nil) => value.Equals(default(noToolchain));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noToolchain value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noToolchain value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noToolchain value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noToolchain(NilType nil) => default(noToolchain);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noToolchain noToolchain_cast(dynamic value)
        {
            return new noToolchain();
        }
    }
}}}}