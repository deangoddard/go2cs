//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:31:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class mvs_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Graph
        {
            // Constructors
            public Graph(NilType _)
            {
                this.cmp = default;
                this.roots = default;
                this.required = default;
                this.isRoot = default;
                this.selected = default;
            }

            public Graph(Func<@string, @string, nint> cmp = default, slice<module.Version> roots = default, map<module.Version, slice<module.Version>> required = default, map<module.Version, bool> isRoot = default, map<@string, @string> selected = default)
            {
                this.cmp = cmp;
                this.roots = roots;
                this.required = required;
                this.isRoot = isRoot;
                this.selected = selected;
            }

            // Enable comparisons between nil and Graph struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Graph value, NilType nil) => value.Equals(default(Graph));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Graph value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Graph value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Graph value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Graph(NilType nil) => default(Graph);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Graph Graph_cast(dynamic value)
        {
            return new Graph(value.cmp, value.roots, value.required, value.isRoot, value.selected);
        }
    }
}}}}