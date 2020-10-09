//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using types = go.go.types_package;
using big = go.math.big_package;
using os = go.os_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(big.Int))]
        private partial struct blockSet
        {
            // Int structure promotion - sourced from value copy
            private readonly ptr<Int> m_IntRef;

            private ref Int Int_val => ref m_IntRef.Value;

            public ref bool neg => ref m_IntRef.Value.neg;

            public ref nat abs => ref m_IntRef.Value.abs;

            // Constructors
            public blockSet(NilType _)
            {
                this.m_IntRef = new ptr<big.Int>(new big.Int(nil));
            }

            public blockSet(big.Int Int = default)
            {
                this.m_IntRef = new ptr<big.Int>(Int);
            }

            // Enable comparisons between nil and blockSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(blockSet value, NilType nil) => value.Equals(default(blockSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(blockSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, blockSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, blockSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator blockSet(NilType nil) => default(blockSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static blockSet blockSet_cast(dynamic value)
        {
            return new blockSet(value.Int);
        }
    }
}}}}}