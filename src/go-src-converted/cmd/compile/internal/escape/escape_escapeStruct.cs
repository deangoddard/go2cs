//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:22:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using math = go.math_package;
using strings = go.strings_package;
using @base = go.cmd.compile.@internal.@base_package;
using ir = go.cmd.compile.@internal.ir_package;
using logopt = go.cmd.compile.@internal.logopt_package;
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
    public static partial class escape_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct escape
        {
            // Constructors
            public escape(NilType _)
            {
                this.ptr<batch> = default;
                this.curfn = default;
                this.labels = default;
                this.loopDepth = default;
            }

            public escape(ref ptr<batch> ptr<batch> = default, ref ptr<ir.Func> curfn = default, map<ptr<types.Sym>, labelState> labels = default, nint loopDepth = default)
            {
                this.ptr<batch> = ptr<batch>;
                this.curfn = curfn;
                this.labels = labels;
                this.loopDepth = loopDepth;
            }

            // Enable comparisons between nil and escape struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(escape value, NilType nil) => value.Equals(default(escape));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(escape value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, escape value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, escape value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator escape(NilType nil) => default(escape);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static escape escape_cast(dynamic value)
        {
            return new escape(ref value.ptr<batch>, ref value.curfn, value.labels, value.loopDepth);
        }
    }
}}}}