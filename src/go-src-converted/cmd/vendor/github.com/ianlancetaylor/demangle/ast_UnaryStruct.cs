//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Unary
        {
            // Constructors
            public Unary(NilType _)
            {
                this.Op = default;
                this.Expr = default;
                this.Suffix = default;
                this.SizeofType = default;
            }

            public Unary(AST Op = default, AST Expr = default, bool Suffix = default, bool SizeofType = default)
            {
                this.Op = Op;
                this.Expr = Expr;
                this.Suffix = Suffix;
                this.SizeofType = SizeofType;
            }

            // Enable comparisons between nil and Unary struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Unary value, NilType nil) => value.Equals(default(Unary));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Unary value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Unary value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Unary value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Unary(NilType nil) => default(Unary);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Unary Unary_cast(dynamic value)
        {
            return new Unary(value.Op, value.Expr, value.Suffix, value.SizeofType);
        }
    }
}}}}}