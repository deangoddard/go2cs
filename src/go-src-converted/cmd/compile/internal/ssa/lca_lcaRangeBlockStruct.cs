//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:01:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bits = go.math.bits_package;
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
        private partial struct lcaRangeBlock
        {
            // Constructors
            public lcaRangeBlock(NilType _)
            {
                this.b = default;
                this.parent = default;
                this.firstChild = default;
                this.sibling = default;
                this.pos = default;
                this.depth = default;
            }

            public lcaRangeBlock(ref ptr<Block> b = default, ID parent = default, ID firstChild = default, ID sibling = default, int pos = default, int depth = default)
            {
                this.b = b;
                this.parent = parent;
                this.firstChild = firstChild;
                this.sibling = sibling;
                this.pos = pos;
                this.depth = depth;
            }

            // Enable comparisons between nil and lcaRangeBlock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lcaRangeBlock value, NilType nil) => value.Equals(default(lcaRangeBlock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lcaRangeBlock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lcaRangeBlock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lcaRangeBlock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lcaRangeBlock(NilType nil) => default(lcaRangeBlock);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static lcaRangeBlock lcaRangeBlock_cast(dynamic value)
        {
            return new lcaRangeBlock(ref value.b, value.parent, value.firstChild, value.sibling, value.pos, value.depth);
        }
    }
}}}}