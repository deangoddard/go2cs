//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct exprInfo
        {
            // Constructors
            public exprInfo(NilType _)
            {
                this.isLhs = default;
                this.mode = default;
                this.typ = default;
                this.val = default;
            }

            public exprInfo(bool isLhs = default, operandMode mode = default, ref ptr<Basic> typ = default, constant.Value val = default)
            {
                this.isLhs = isLhs;
                this.mode = mode;
                this.typ = typ;
                this.val = val;
            }

            // Enable comparisons between nil and exprInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(exprInfo value, NilType nil) => value.Equals(default(exprInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(exprInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, exprInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, exprInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator exprInfo(NilType nil) => default(exprInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static exprInfo exprInfo_cast(dynamic value)
        {
            return new exprInfo(value.isLhs, value.mode, ref value.typ, value.val);
        }
    }
}}