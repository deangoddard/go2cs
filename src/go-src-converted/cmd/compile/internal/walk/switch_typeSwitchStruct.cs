//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:25:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using constant = go.go.constant_package;
using token = go.go.token_package;
using sort = go.sort_package;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using typecheck = go.cmd.compile.@internal.typecheck_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class walk_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct typeSwitch
        {
            // Constructors
            public typeSwitch(NilType _)
            {
                this.facename = default;
                this.hashname = default;
                this.okname = default;
                this.done = default;
                this.clauses = default;
            }

            public typeSwitch(ir.Node facename = default, ir.Node hashname = default, ir.Node okname = default, ir.Nodes done = default, slice<typeClause> clauses = default)
            {
                this.facename = facename;
                this.hashname = hashname;
                this.okname = okname;
                this.done = done;
                this.clauses = clauses;
            }

            // Enable comparisons between nil and typeSwitch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeSwitch value, NilType nil) => value.Equals(default(typeSwitch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeSwitch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeSwitch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeSwitch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeSwitch(NilType nil) => default(typeSwitch);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static typeSwitch typeSwitch_cast(dynamic value)
        {
            return new typeSwitch(value.facename, value.hashname, value.okname, value.done, value.clauses);
        }
    }
}}}}