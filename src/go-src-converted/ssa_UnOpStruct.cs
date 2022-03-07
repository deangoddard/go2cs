//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sync = go.sync_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
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
        [PromotedStruct(typeof(register))]
        public partial struct UnOp
        {
            // register structure promotion - sourced from value copy
            private readonly ptr<register> m_registerRef;

            private ref register register_val => ref m_registerRef.Value;

            public ref nint num => ref m_registerRef.Value.num;

            public ref types.Type typ => ref m_registerRef.Value.typ;

            public ref token.Pos pos => ref m_registerRef.Value.pos;

            public ref slice<Instruction> referrers => ref m_registerRef.Value.referrers;

            // Constructors
            public UnOp(NilType _)
            {
                this.m_registerRef = new ptr<register>(new register(nil));
                this.Op = default;
                this.X = default;
                this.CommaOk = default;
            }

            public UnOp(register register = default, token.Token Op = default, Value X = default, bool CommaOk = default)
            {
                this.m_registerRef = new ptr<register>(register);
                this.Op = Op;
                this.X = X;
                this.CommaOk = CommaOk;
            }

            // Enable comparisons between nil and UnOp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnOp value, NilType nil) => value.Equals(default(UnOp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnOp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnOp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnOp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnOp(NilType nil) => default(UnOp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnOp UnOp_cast(dynamic value)
        {
            return new UnOp(value.register, value.Op, value.X, value.CommaOk);
        }
    }
}}}}}