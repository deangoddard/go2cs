//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct loopnest
        {
            // Constructors
            public loopnest(NilType _)
            {
                this.f = default;
                this.b2l = default;
                this.po = default;
                this.sdom = default;
                this.loops = default;
                this.hasIrreducible = default;
                this.initializedChildren = default;
                this.initializedDepth = default;
                this.initializedExits = default;
            }

            public loopnest(ref ptr<Func> f = default, slice<ptr<loop>> b2l = default, slice<ptr<Block>> po = default, SparseTree sdom = default, slice<ptr<loop>> loops = default, bool hasIrreducible = default, bool initializedChildren = default, bool initializedDepth = default, bool initializedExits = default)
            {
                this.f = f;
                this.b2l = b2l;
                this.po = po;
                this.sdom = sdom;
                this.loops = loops;
                this.hasIrreducible = hasIrreducible;
                this.initializedChildren = initializedChildren;
                this.initializedDepth = initializedDepth;
                this.initializedExits = initializedExits;
            }

            // Enable comparisons between nil and loopnest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loopnest value, NilType nil) => value.Equals(default(loopnest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loopnest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loopnest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loopnest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loopnest(NilType nil) => default(loopnest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static loopnest loopnest_cast(dynamic value)
        {
            return new loopnest(ref value.f, value.b2l, value.po, value.sdom, value.loops, value.hasIrreducible, value.initializedChildren, value.initializedDepth, value.initializedExits);
        }
    }
}}}}