//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gob = go.encoding.gob_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using format = go.go.format_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using trace = go.runtime.trace_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using analysisflags = go.golang.org.x.tools.go.analysis.@internal.analysisflags_package;
using packages = go.golang.org.x.tools.go.packages_package;
using analysisinternal = go.golang.org.x.tools.@internal.analysisinternal_package;
using span = go.golang.org.x.tools.@internal.span_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace @internal
{
    public static partial class checker_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct node
        {
            // Constructors
            public node(NilType _)
            {
                this.edit = default;
                this.left = default;
                this.right = default;
            }

            public node(offsetedit edit = default, ref ptr<node> left = default, ref ptr<node> right = default)
            {
                this.edit = edit;
                this.left = left;
                this.right = right;
            }

            // Enable comparisons between nil and node struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(node value, NilType nil) => value.Equals(default(node));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(node value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, node value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, node value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator node(NilType nil) => default(node);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static node node_cast(dynamic value)
        {
            return new node(value.edit, ref value.left, ref value.right);
        }
    }
}}}}}}}