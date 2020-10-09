//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:04:49 UTC
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
using log = go.log_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
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
    public static partial class unreachable_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct deadState
        {
            // Constructors
            public deadState(NilType _)
            {
                this.pass = default;
                this.hasBreak = default;
                this.hasGoto = default;
                this.labels = default;
                this.breakTarget = default;
                this.reachable = default;
            }

            public deadState(ref ptr<analysis.Pass> pass = default, map<ast.Stmt, bool> hasBreak = default, map<@string, bool> hasGoto = default, map<@string, ast.Stmt> labels = default, ast.Stmt breakTarget = default, bool reachable = default)
            {
                this.pass = pass;
                this.hasBreak = hasBreak;
                this.hasGoto = hasGoto;
                this.labels = labels;
                this.breakTarget = breakTarget;
                this.reachable = reachable;
            }

            // Enable comparisons between nil and deadState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(deadState value, NilType nil) => value.Equals(default(deadState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(deadState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, deadState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, deadState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator deadState(NilType nil) => default(deadState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static deadState deadState_cast(dynamic value)
        {
            return new deadState(ref value.pass, value.hasBreak, value.hasGoto, value.labels, value.breakTarget, value.reachable);
        }
    }
}}}}}}}}}