//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:43:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Nodes
        {
            // Constructors
            public Nodes(NilType _)
            {
                this.slice = default;
            }

            public Nodes(ref ptr<slice<ptr<Node>>> slice = default)
            {
                this.slice = slice;
            }

            // Enable comparisons between nil and Nodes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Nodes value, NilType nil) => value.Equals(default(Nodes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Nodes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Nodes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Nodes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nodes(NilType nil) => default(Nodes);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Nodes Nodes_cast(dynamic value)
        {
            return new Nodes(ref value.slice);
        }
    }
}}}}