//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:12:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syntax = go.cmd.compile.@internal.syntax_package;
using fmt = go.fmt_package;
using atomic = go.sync.atomic_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Named
        {
            // Constructors
            public Named(NilType _)
            {
                this.check = default;
                this.info = default;
                this.obj = default;
                this.orig = default;
                this.fromRHS = default;
                this.underlying = default;
                this.tparams = default;
                this.targs = default;
                this.methods = default;
            }

            public Named(ref ptr<Checker> check = default, typeInfo info = default, ref ptr<TypeName> obj = default, ref ptr<Named> orig = default, Type fromRHS = default, Type underlying = default, slice<ptr<TypeName>> tparams = default, slice<Type> targs = default, slice<ptr<Func>> methods = default)
            {
                this.check = check;
                this.info = info;
                this.obj = obj;
                this.orig = orig;
                this.fromRHS = fromRHS;
                this.underlying = underlying;
                this.tparams = tparams;
                this.targs = targs;
                this.methods = methods;
            }

            // Enable comparisons between nil and Named struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Named value, NilType nil) => value.Equals(default(Named));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Named value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Named value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Named value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Named(NilType nil) => default(Named);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Named Named_cast(dynamic value)
        {
            return new Named(ref value.check, value.info, ref value.obj, ref value.orig, value.fromRHS, value.underlying, value.tparams, value.targs, value.methods);
        }
    }
}}}}