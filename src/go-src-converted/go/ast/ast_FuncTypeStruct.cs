//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using token = go.go.token_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FuncType
        {
            // Constructors
            public FuncType(NilType _)
            {
                this.Func = default;
                this.Params = default;
                this.Results = default;
            }

            public FuncType(token.Pos Func = default, ref ptr<FieldList> Params = default, ref ptr<FieldList> Results = default)
            {
                this.Func = Func;
                this.Params = Params;
                this.Results = Results;
            }

            // Enable comparisons between nil and FuncType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FuncType value, NilType nil) => value.Equals(default(FuncType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FuncType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FuncType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FuncType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FuncType(NilType nil) => default(FuncType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FuncType FuncType_cast(dynamic value)
        {
            return new FuncType(value.Func, ref value.Params, ref value.Results);
        }
    }
}}