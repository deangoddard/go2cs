//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:46:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using exec = go.@internal.execabs_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using objabi = go.cmd.@internal.objabi_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Scope
        {
            // Constructors
            public Scope(NilType _)
            {
                this.Parent = default;
                this.Ranges = default;
                this.Vars = default;
            }

            public Scope(int Parent = default, slice<Range> Ranges = default, slice<ptr<Var>> Vars = default)
            {
                this.Parent = Parent;
                this.Ranges = Ranges;
                this.Vars = Vars;
            }

            // Enable comparisons between nil and Scope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Scope value, NilType nil) => value.Equals(default(Scope));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Scope value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Scope value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Scope value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Scope(NilType nil) => default(Scope);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Scope Scope_cast(dynamic value)
        {
            return new Scope(value.Parent, value.Ranges, value.Vars);
        }
    }
}}}