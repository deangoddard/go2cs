//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct block
        {
            // Constructors
            public block(NilType _)
            {
                this.parent = default;
                this.lstmt = default;
                this.labels = default;
            }

            public block(ref ptr<block> parent = default, ref ptr<ast.LabeledStmt> lstmt = default, map<@string, ref ast.LabeledStmt> labels = default)
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

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static block block_cast(dynamic value)
        {
            return new block(ref value.parent, ref value.lstmt, value.labels);
        }
    }
}}