//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:47:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Type
        {
            // Constructors
            public Type(NilType _)
            {
                this.Width = default;
                this.methods = default;
                this.allMethods = default;
                this.nod = default;
                this.underlying = default;
                this.sym = default;
                this.Vargen = default;
                this.kind = default;
                this.Align = default;
                this.flags = default;
                this.rparams = default;
            }

            public Type(long Width = default, Fields methods = default, Fields allMethods = default, Object nod = default, ref ptr<Type> underlying = default, ref ptr<Sym> sym = default, int Vargen = default, Kind kind = default, byte Align = default, bitset8 flags = default, ref ptr<slice<ptr<Type>>> rparams = default)
            {
                this.Width = Width;
                this.methods = methods;
                this.allMethods = allMethods;
                this.nod = nod;
                this.underlying = underlying;
                this.sym = sym;
                this.Vargen = Vargen;
                this.kind = kind;
                this.Align = Align;
                this.flags = flags;
                this.rparams = rparams;
            }

            // Enable comparisons between nil and Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Type value, NilType nil) => value.Equals(default(Type));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Type value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Type value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Type value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Type(NilType nil) => default(Type);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Type Type_cast(dynamic value)
        {
            return new Type(value.Width, value.methods, value.allMethods, value.nod, ref value.underlying, ref value.sym, value.Vargen, value.kind, value.Align, value.flags, ref value.rparams);
        }
    }
}}}}