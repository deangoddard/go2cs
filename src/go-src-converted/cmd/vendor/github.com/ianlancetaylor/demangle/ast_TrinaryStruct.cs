//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:37:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Trinary
        {
            // Constructors
            public Trinary(NilType _)
            {
                this.Op = default;
                this.First = default;
                this.Second = default;
                this.Third = default;
            }

            public Trinary(AST Op = default, AST First = default, AST Second = default, AST Third = default)
            {
                this.Op = Op;
                this.First = First;
                this.Second = Second;
                this.Third = Third;
            }

            // Enable comparisons between nil and Trinary struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Trinary value, NilType nil) => value.Equals(default(Trinary));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Trinary value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Trinary value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Trinary value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Trinary(NilType nil) => default(Trinary);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Trinary Trinary_cast(dynamic value)
        {
            return new Trinary(value.Op, value.First, value.Second, value.Third);
        }
    }
}}}}}