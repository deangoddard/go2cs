//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct Const
        {
            // Constructors
            public Const(NilType _)
            {
                this.typ = default;
                this.Value = default;
            }

            public Const(types.Type typ = default, constant.Value Value = default)
            {
                this.typ = typ;
                this.Value = Value;
            }

            // Enable comparisons between nil and Const struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Const value, NilType nil) => value.Equals(default(Const));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Const value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Const value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Const value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Const(NilType nil) => default(Const);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Const Const_cast(dynamic value)
        {
            return new Const(value.typ, value.Value);
        }
    }
}}}}}