//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:26:51 UTC
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
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct EscStep
        {
            // Constructors
            public EscStep(NilType _)
            {
                this.src = default;
                this.dst = default;
                this.where = default;
                this.parent = default;
                this.why = default;
                this.busy = default;
            }

            public EscStep(ref ptr<Node> src = default, ref ptr<Node> dst = default, ref ptr<Node> where = default, ref ptr<EscStep> parent = default, @string why = default, bool busy = default)
            {
                this.src = src;
                this.dst = dst;
                this.where = where;
                this.parent = parent;
                this.why = why;
                this.busy = busy;
            }

            // Enable comparisons between nil and EscStep struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EscStep value, NilType nil) => value.Equals(default(EscStep));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EscStep value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EscStep value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EscStep value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EscStep(NilType nil) => default(EscStep);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static EscStep EscStep_cast(dynamic value)
        {
            return new EscStep(ref value.src, ref value.dst, ref value.where, ref value.parent, value.why, value.busy);
        }
    }
}}}}