//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
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
        public partial struct BlockKind
        {
            // Value of the BlockKind struct
            private readonly sbyte m_value;
            
            public BlockKind(sbyte value) => m_value = value;

            // Enable implicit conversions between sbyte and BlockKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlockKind(sbyte value) => new BlockKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sbyte(BlockKind value) => value.m_value;
            
            // Enable comparisons between nil and BlockKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BlockKind value, NilType nil) => value.Equals(default(BlockKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BlockKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BlockKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BlockKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BlockKind(NilType nil) => default(BlockKind);
        }
    }
}}}}
