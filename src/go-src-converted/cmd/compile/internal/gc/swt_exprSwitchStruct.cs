//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:29:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct exprSwitch
        {
            // Constructors
            public exprSwitch(NilType _)
            {
                this.exprname = default;
                this.kind = default;
            }

            public exprSwitch(ref ptr<Node> exprname = default, long kind = default)
            {
                this.exprname = exprname;
                this.kind = kind;
            }

            // Enable comparisons between nil and exprSwitch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(exprSwitch value, NilType nil) => value.Equals(default(exprSwitch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(exprSwitch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, exprSwitch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, exprSwitch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator exprSwitch(NilType nil) => default(exprSwitch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static exprSwitch exprSwitch_cast(dynamic value)
        {
            return new exprSwitch(ref value.exprname, value.kind);
        }
    }
}}}}