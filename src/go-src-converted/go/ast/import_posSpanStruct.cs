//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:42:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using token = go.go.token_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct posSpan
        {
            // Constructors
            public posSpan(NilType _)
            {
                this.Start = default;
                this.End = default;
            }

            public posSpan(token.Pos Start = default, token.Pos End = default)
            {
                this.Start = Start;
                this.End = End;
            }

            // Enable comparisons between nil and posSpan struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(posSpan value, NilType nil) => value.Equals(default(posSpan));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(posSpan value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, posSpan value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, posSpan value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator posSpan(NilType nil) => default(posSpan);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static posSpan posSpan_cast(dynamic value)
        {
            return new posSpan(value.Start, value.End);
        }
    }
}}