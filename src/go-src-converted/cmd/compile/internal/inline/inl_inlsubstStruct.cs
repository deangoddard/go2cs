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
        private partial struct inlsubst
        {
            // Constructors
            public inlsubst(NilType _)
            {
                this.retlabel = default;
                this.retvars = default;
                this.delayretvars = default;
                this.inlvars = default;
                this.defnMarker = default;
                this.bases = default;
                this.newInlIndex = default;
                this.edit = default;
                this.newclofn = default;
                this.fn = default;
                this.noPosUpdate = default;
            }

            public inlsubst(ref ptr<types.Sym> retlabel = default, slice<ir.Node> retvars = default, bool delayretvars = default, map<ptr<ir.Name>, ptr<ir.Name>> inlvars = default, ir.NilExpr defnMarker = default, map<ptr<src.PosBase>, ptr<src.PosBase>> bases = default, nint newInlIndex = default, Func<ir.Node, ir.Node> edit = default, ref ptr<ir.Func> newclofn = default, ref ptr<ir.Func> fn = default, bool noPosUpdate = default)
            {
                this.retlabel = retlabel;
                this.retvars = retvars;
                this.delayretvars = delayretvars;
                this.inlvars = inlvars;
                this.defnMarker = defnMarker;
                this.bases = bases;
                this.newInlIndex = newInlIndex;
                this.edit = edit;
                this.newclofn = newclofn;
                this.fn = fn;
                this.noPosUpdate = noPosUpdate;
            }

            // Enable comparisons between nil and inlsubst struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(inlsubst value, NilType nil) => value.Equals(default(inlsubst));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(inlsubst value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, inlsubst value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, inlsubst value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inlsubst(NilType nil) => default(inlsubst);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static inlsubst inlsubst_cast(dynamic value)
        {
            return new inlsubst(ref value.retlabel, value.retvars, value.delayretvars, value.inlvars, value.defnMarker, value.bases, value.newInlIndex, value.edit, ref value.newclofn, ref value.fn, value.noPosUpdate);
        }
    }
}}}}