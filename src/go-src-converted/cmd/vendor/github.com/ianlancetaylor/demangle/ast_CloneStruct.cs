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
        public partial struct Clone
        {
            // Constructors
            public Clone(NilType _)
            {
                this.Base = default;
                this.Suffix = default;
            }

            public Clone(AST Base = default, @string Suffix = default)
            {
                this.Base = Base;
                this.Suffix = Suffix;
            }

            // Enable comparisons between nil and Clone struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Clone value, NilType nil) => value.Equals(default(Clone));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Clone value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Clone value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Clone value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Clone(NilType nil) => default(Clone);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Clone Clone_cast(dynamic value)
        {
            return new Clone(value.Base, value.Suffix);
        }
    }
}}}}}