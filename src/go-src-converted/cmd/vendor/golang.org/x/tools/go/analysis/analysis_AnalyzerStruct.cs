//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using token = go.go.token_package;
using types = go.go.types_package;
using reflect = go.reflect_package;
using analysisinternal = go.golang.org.x.tools.@internal.analysisinternal_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class analysis_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Analyzer
        {
            // Constructors
            public Analyzer(NilType _)
            {
                this.Name = default;
                this.Doc = default;
                this.Flags = default;
                this.Run = default;
                this.RunDespiteErrors = default;
                this.Requires = default;
                this.ResultType = default;
                this.FactTypes = default;
            }

            public Analyzer(@string Name = default, @string Doc = default, flag.FlagSet Flags = default, Func<ptr<Pass>, (object, error)> Run = default, bool RunDespiteErrors = default, slice<ptr<Analyzer>> Requires = default, reflect.Type ResultType = default, slice<Fact> FactTypes = default)
            {
                this.Name = Name;
                this.Doc = Doc;
                this.Flags = Flags;
                this.Run = Run;
                this.RunDespiteErrors = RunDespiteErrors;
                this.Requires = Requires;
                this.ResultType = ResultType;
                this.FactTypes = FactTypes;
            }

            // Enable comparisons between nil and Analyzer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Analyzer value, NilType nil) => value.Equals(default(Analyzer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Analyzer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Analyzer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Analyzer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Analyzer(NilType nil) => default(Analyzer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Analyzer Analyzer_cast(dynamic value)
        {
            return new Analyzer(value.Name, value.Doc, value.Flags, value.Run, value.RunDespiteErrors, value.Requires, value.ResultType, value.FactTypes);
        }
    }
}}}}}}}