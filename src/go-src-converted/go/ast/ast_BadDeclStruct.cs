//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct BadDecl
        {
            // Constructors
            public BadDecl(NilType _)
            {
                this.From = default;
                this.To = default;
            }

            public BadDecl(token.Pos From = default, token.Pos To = default)
            {
                this.From = From;
                this.To = To;
            }

            // Enable comparisons between nil and BadDecl struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BadDecl value, NilType nil) => value.Equals(default(BadDecl));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BadDecl value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BadDecl value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BadDecl value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BadDecl(NilType nil) => default(BadDecl);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BadDecl BadDecl_cast(dynamic value)
        {
            return new BadDecl(value.From, value.To);
        }
    }
}}