//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:59:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using src = go.cmd.@internal.src_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct dsym
        {
            // Constructors
            public dsym(NilType _)
            {
                this.sym = default;
                this.def = default;
                this.block = default;
                this.lastlineno = default;
            }

            public dsym(ref ptr<Sym> sym = default, Object def = default, int block = default, src.XPos lastlineno = default)
            {
                this.sym = sym;
                this.def = def;
                this.block = block;
                this.lastlineno = lastlineno;
            }

            // Enable comparisons between nil and dsym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dsym value, NilType nil) => value.Equals(default(dsym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dsym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dsym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dsym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dsym(NilType nil) => default(dsym);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static dsym dsym_cast(dynamic value)
        {
            return new dsym(ref value.sym, value.def, value.block, value.lastlineno);
        }
    }
}}}}