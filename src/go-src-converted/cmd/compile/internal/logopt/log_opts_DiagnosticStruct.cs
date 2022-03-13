//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:59:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using io = go.io_package;
using log = go.log_package;
using url = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class logopt_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Diagnostic
        {
            // Constructors
            public Diagnostic(NilType _)
            {
                this.Range = default;
                this.Severity = default;
                this.Code = default;
                this.Source = default;
                this.Message = default;
                this.Tags = default;
                this.RelatedInformation = default;
            }

            public Diagnostic(Range Range = default, DiagnosticSeverity Severity = default, @string Code = default, @string Source = default, @string Message = default, slice<DiagnosticTag> Tags = default, slice<DiagnosticRelatedInformation> RelatedInformation = default)
            {
                this.Range = Range;
                this.Severity = Severity;
                this.Code = Code;
                this.Source = Source;
                this.Message = Message;
                this.Tags = Tags;
                this.RelatedInformation = RelatedInformation;
            }

            // Enable comparisons between nil and Diagnostic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Diagnostic value, NilType nil) => value.Equals(default(Diagnostic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Diagnostic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Diagnostic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Diagnostic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Diagnostic(NilType nil) => default(Diagnostic);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Diagnostic Diagnostic_cast(dynamic value)
        {
            return new Diagnostic(value.Range, value.Severity, value.Code, value.Source, value.Message, value.Tags, value.RelatedInformation);
        }
    }
}}}}