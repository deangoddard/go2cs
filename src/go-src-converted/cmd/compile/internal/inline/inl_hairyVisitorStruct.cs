//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:09:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using strings = go.strings_package;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using logopt = go.cmd.compile.@internal.logopt_package;
using typecheck = go.cmd.compile.@internal.typecheck_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class inline_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct hairyVisitor
        {
            // Constructors
            public hairyVisitor(NilType _)
            {
                this.budget = default;
                this.reason = default;
                this.extraCallCost = default;
                this.usedLocals = default;
                this.@do = default;
            }

            public hairyVisitor(int budget = default, @string reason = default, int extraCallCost = default, ir.NameSet usedLocals = default, Func<ir.Node, bool> @do = default)
            {
                this.budget = budget;
                this.reason = reason;
                this.extraCallCost = extraCallCost;
                this.usedLocals = usedLocals;
                this.@do = @do;
            }

            // Enable comparisons between nil and hairyVisitor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hairyVisitor value, NilType nil) => value.Equals(default(hairyVisitor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hairyVisitor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hairyVisitor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hairyVisitor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hairyVisitor(NilType nil) => default(hairyVisitor);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static hairyVisitor hairyVisitor_cast(dynamic value)
        {
            return new hairyVisitor(value.budget, value.reason, value.extraCallCost, value.usedLocals, value.@do);
        }
    }
}}}}