//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using gob = go.encoding.gob_package;
using json = go.encoding.json_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using importer = go.go.importer_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using analysisflags = go.golang.org.x.tools.go.analysis.@internal.analysisflags_package;
using facts = go.golang.org.x.tools.go.analysis.@internal.facts_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis
{
    public static partial class unitchecker_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct action
        {
            // Constructors
            public action(NilType _)
            {
                this.once = default;
                this.err = default;
                this.usesFacts = default;
                this.diagnostics = default;
            }

            public action(sync.Once once = default, error err = default, bool usesFacts = default, slice<analysis.Diagnostic> diagnostics = default)
            {
                this.once = once;
                this.err = err;
                this.usesFacts = usesFacts;
                this.diagnostics = diagnostics;
            }

            // Enable comparisons between nil and action struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(action value, NilType nil) => value.Equals(default(action));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(action value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, action value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, action value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator action(NilType nil) => default(action);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static action action_cast(dynamic value)
        {
            return new action(value.once, value.err, value.usesFacts, value.diagnostics);
        }
    }
}}}}}}