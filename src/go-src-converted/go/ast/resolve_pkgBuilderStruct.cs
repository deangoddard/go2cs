//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:48:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using scanner = go.go.scanner_package;
using token = go.go.token_package;
using strconv = go.strconv_package;
using go;

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pkgBuilder
        {
            // Constructors
            public pkgBuilder(NilType _)
            {
                this.fset = default;
                this.errors = default;
            }

            public pkgBuilder(ref ptr<token.FileSet> fset = default, scanner.ErrorList errors = default)
            {
                this.fset = fset;
                this.errors = errors;
            }

            // Enable comparisons between nil and pkgBuilder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pkgBuilder value, NilType nil) => value.Equals(default(pkgBuilder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pkgBuilder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pkgBuilder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pkgBuilder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pkgBuilder(NilType nil) => default(pkgBuilder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pkgBuilder pkgBuilder_cast(dynamic value)
        {
            return new pkgBuilder(ref value.fset, value.errors);
        }
    }
}}