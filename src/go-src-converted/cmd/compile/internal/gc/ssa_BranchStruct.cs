//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:29:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using html = go.html_package;
using os = go.os_package;
using sort = go.sort_package;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Branch
        {
            // Constructors
            public Branch(NilType _)
            {
                this.P = default;
                this.B = default;
            }

            public Branch(ref ptr<obj.Prog> P = default, ref ptr<ssa.Block> B = default)
            {
                this.P = P;
                this.B = B;
            }

            // Enable comparisons between nil and Branch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Branch value, NilType nil) => value.Equals(default(Branch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Branch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Branch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Branch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Branch(NilType nil) => default(Branch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Branch Branch_cast(dynamic value)
        {
            return new Branch(ref value.P, ref value.B);
        }
    }
}}}}