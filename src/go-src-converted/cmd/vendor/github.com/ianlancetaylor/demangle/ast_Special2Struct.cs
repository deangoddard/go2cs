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
        public partial struct Special2
        {
            // Constructors
            public Special2(NilType _)
            {
                this.Prefix = default;
                this.Val1 = default;
                this.Middle = default;
                this.Val2 = default;
            }

            public Special2(@string Prefix = default, AST Val1 = default, @string Middle = default, AST Val2 = default)
            {
                this.Prefix = Prefix;
                this.Val1 = Val1;
                this.Middle = Middle;
                this.Val2 = Val2;
            }

            // Enable comparisons between nil and Special2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Special2 value, NilType nil) => value.Equals(default(Special2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Special2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Special2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Special2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Special2(NilType nil) => default(Special2);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Special2 Special2_cast(dynamic value)
        {
            return new Special2(value.Prefix, value.Val1, value.Middle, value.Val2);
        }
    }
}}}}}