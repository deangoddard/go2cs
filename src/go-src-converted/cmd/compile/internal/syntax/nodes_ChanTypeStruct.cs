//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:26:36 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(expr))]
        public partial struct ChanType
        {
            // expr structure promotion - sourced from value copy
            private readonly ptr<expr> m_exprRef;

            private ref expr expr_val => ref m_exprRef.Value;

            // Constructors
            public ChanType(NilType _)
            {
                this.Dir = default;
                this.Elem = default;
                this.m_exprRef = new ptr<expr>(new expr(nil));
            }

            public ChanType(ChanDir Dir = default, Expr Elem = default, expr expr = default)
            {
                this.Dir = Dir;
                this.Elem = Elem;
                this.m_exprRef = new ptr<expr>(expr);
            }

            // Enable comparisons between nil and ChanType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ChanType value, NilType nil) => value.Equals(default(ChanType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ChanType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ChanType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ChanType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ChanType(NilType nil) => default(ChanType);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static ChanType ChanType_cast(dynamic value)
        {
            return new ChanType(value.Dir, value.Elem, value.expr);
        }
    }
}}}}