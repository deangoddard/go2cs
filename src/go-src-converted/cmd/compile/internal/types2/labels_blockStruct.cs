//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:26:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syntax = go.cmd.compile.@internal.syntax_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct block
        {
            // Constructors
            public block(NilType _)
            {
                this.parent = default;
                this.lstmt = default;
                this.labels = default;
            }

            public block(ref ptr<block> parent = default, ref ptr<syntax.LabeledStmt> lstmt = default, map<@string, ptr<syntax.LabeledStmt>> labels = default)
            {
                this.parent = parent;
                this.lstmt = lstmt;
                this.labels = labels;
            }

            // Enable comparisons between nil and block struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(block value, NilType nil) => value.Equals(default(block));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(block value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, block value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, block value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator block(NilType nil) => default(block);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static block block_cast(dynamic value)
        {
            return new block(ref value.parent, ref value.lstmt, value.labels);
        }
    }
}}}}