//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:13:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct SliceType
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public SliceType(NilType _)
            {
                this.Elem = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public SliceType(Expr Elem = default, expr expr = default)
            {
                this.Elem = Elem;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and SliceType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SliceType value, NilType nil) => value.Equals(default(SliceType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SliceType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SliceType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SliceType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SliceType(NilType nil) => default(SliceType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SliceType SliceType_cast(dynamic value)
        {
            return new SliceType(value.Elem, value.expr);
        }
    }
}}}}