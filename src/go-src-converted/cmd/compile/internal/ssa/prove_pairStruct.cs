//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:02:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using math = go.math_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct pair
        {
            // Constructors
            public pair(NilType _)
            {
                this.v = default;
                this.w = default;
                this.d = default;
            }

            public pair(ref ptr<Value> v = default, ref ptr<Value> w = default, domain d = default)
            {
                this.v = v;
                this.w = w;
                this.d = d;
            }

            // Enable comparisons between nil and pair struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pair value, NilType nil) => value.Equals(default(pair));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pair value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pair value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pair value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pair(NilType nil) => default(pair);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static pair pair_cast(dynamic value)
        {
            return new pair(ref value.v, ref value.w, value.d);
        }
    }
}}}}