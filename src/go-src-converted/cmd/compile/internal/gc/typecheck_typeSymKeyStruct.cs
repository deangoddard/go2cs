//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:43:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typeSymKey
        {
            // Constructors
            public typeSymKey(NilType _)
            {
                this.t = default;
                this.s = default;
            }

            public typeSymKey(ref ptr<types.Type> t = default, ref ptr<types.Sym> s = default)
            {
                this.t = t;
                this.s = s;
            }

            // Enable comparisons between nil and typeSymKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeSymKey value, NilType nil) => value.Equals(default(typeSymKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeSymKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeSymKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeSymKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeSymKey(NilType nil) => default(typeSymKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typeSymKey typeSymKey_cast(dynamic value)
        {
            return new typeSymKey(ref value.t, ref value.s);
        }
    }
}}}}