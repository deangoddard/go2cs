//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:12 UTC
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

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Fold
        {
            // Constructors
            public Fold(NilType _)
            {
                this.Left = default;
                this.Op = default;
                this.Arg1 = default;
                this.Arg2 = default;
            }

            public Fold(bool Left = default, AST Op = default, AST Arg1 = default, AST Arg2 = default)
            {
                this.Left = Left;
                this.Op = Op;
                this.Arg1 = Arg1;
                this.Arg2 = Arg2;
            }

            // Enable comparisons between nil and Fold struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Fold value, NilType nil) => value.Equals(default(Fold));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Fold value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Fold value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Fold value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Fold(NilType nil) => default(Fold);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Fold Fold_cast(dynamic value)
        {
            return new Fold(value.Left, value.Op, value.Arg1, value.Arg2);
        }
    }
}}}}}