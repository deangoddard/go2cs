//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using src = go.cmd.@internal.src_package;
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
        public partial struct Edge
        {
            // Constructors
            public Edge(NilType _)
            {
                this.b = default;
                this.i = default;
            }

            public Edge(ref ptr<Block> b = default, long i = default)
            {
                this.b = b;
                this.i = i;
            }

            // Enable comparisons between nil and Edge struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Edge value, NilType nil) => value.Equals(default(Edge));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Edge value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Edge value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Edge value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Edge(NilType nil) => default(Edge);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Edge Edge_cast(dynamic value)
        {
            return new Edge(ref value.b, value.i);
        }
    }
}}}}