//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:24:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using heap = go.container.heap_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ValHeap
        {
            // Constructors
            public ValHeap(NilType _)
            {
                this.a = default;
                this.score = default;
            }

            public ValHeap(slice<ref Value> a = default, slice<sbyte> score = default)
            {
                this.a = a;
                this.score = score;
            }

            // Enable comparisons between nil and ValHeap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ValHeap value, NilType nil) => value.Equals(default(ValHeap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ValHeap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ValHeap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ValHeap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValHeap(NilType nil) => default(ValHeap);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ValHeap ValHeap_cast(dynamic value)
        {
            return new ValHeap(value.a, value.score);
        }
    }
}}}}