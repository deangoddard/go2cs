//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:04:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using types = go.go.types_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
using analysisutil = go.golang.org.x.tools.go.analysis.passes.@internal.analysisutil_package;
using inspector = go.golang.org.x.tools.go.ast.inspector_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class bools_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct boolOp
        {
            // Constructors
            public boolOp(NilType _)
            {
                this.name = default;
                this.tok = default;
                this.badEq = default;
            }

            public boolOp(@string name = default, token.Token tok = default, token.Token badEq = default)
            {
                this.name = name;
                this.tok = tok;
                this.badEq = badEq;
            }

            // Enable comparisons between nil and boolOp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(boolOp value, NilType nil) => value.Equals(default(boolOp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(boolOp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, boolOp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, boolOp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator boolOp(NilType nil) => default(boolOp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static boolOp boolOp_cast(dynamic value)
        {
            return new boolOp(value.name, value.tok, value.badEq);
        }
    }
}}}}}}}}}