//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using time = go.time_package;
using graph = go.github.com.google.pprof.@internal.graph_package;
using measurement = go.github.com.google.pprof.@internal.measurement_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using profile = go.github.com.google.pprof.profile_package;
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
    public static partial class report_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct callID
        {
            // Constructors
            public callID(NilType _)
            {
                this.file = default;
                this.line = default;
            }

            public callID(@string file = default, nint line = default)
            {
                this.file = file;
                this.line = line;
            }

            // Enable comparisons between nil and callID struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(callID value, NilType nil) => value.Equals(default(callID));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(callID value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, callID value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, callID value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator callID(NilType nil) => default(callID);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static callID callID_cast(dynamic value)
        {
            return new callID(value.file, value.line);
        }
    }
}}}}}}}