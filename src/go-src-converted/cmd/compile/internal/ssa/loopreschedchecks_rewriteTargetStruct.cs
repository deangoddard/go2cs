//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:54:05 UTC
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
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct rewriteTarget
        {
            // Constructors
            public rewriteTarget(NilType _)
            {
                this.v = default;
                this.i = default;
            }

            public rewriteTarget(ref ptr<Value> v = default, long i = default)
            {
                this.v = v;
                this.i = i;
            }

            // Enable comparisons between nil and rewriteTarget struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rewriteTarget value, NilType nil) => value.Equals(default(rewriteTarget));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rewriteTarget value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rewriteTarget value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rewriteTarget value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rewriteTarget(NilType nil) => default(rewriteTarget);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rewriteTarget rewriteTarget_cast(dynamic value)
        {
            return new rewriteTarget(ref value.v, value.i);
        }
    }
}}}}