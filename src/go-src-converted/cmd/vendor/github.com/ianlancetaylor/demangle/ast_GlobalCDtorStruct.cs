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
        public partial struct GlobalCDtor
        {
            // Constructors
            public GlobalCDtor(NilType _)
            {
                this.Ctor = default;
                this.Key = default;
            }

            public GlobalCDtor(bool Ctor = default, AST Key = default)
            {
                this.Ctor = Ctor;
                this.Key = Key;
            }

            // Enable comparisons between nil and GlobalCDtor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GlobalCDtor value, NilType nil) => value.Equals(default(GlobalCDtor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GlobalCDtor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GlobalCDtor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GlobalCDtor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator GlobalCDtor(NilType nil) => default(GlobalCDtor);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static GlobalCDtor GlobalCDtor_cast(dynamic value)
        {
            return new GlobalCDtor(value.Ctor, value.Key);
        }
    }
}}}}}