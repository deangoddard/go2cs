//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loadmacho_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ldMachoRel
        {
            // Constructors
            public ldMachoRel(NilType _)
            {
                this.addr = default;
                this.symnum = default;
                this.pcrel = default;
                this.length = default;
                this.extrn = default;
                this.type_ = default;
                this.scattered = default;
                this.value = default;
            }

            public ldMachoRel(uint addr = default, uint symnum = default, byte pcrel = default, byte length = default, byte extrn = default, byte type_ = default, byte scattered = default, uint value = default)
            {
                this.addr = addr;
                this.symnum = symnum;
                this.pcrel = pcrel;
                this.length = length;
                this.extrn = extrn;
                this.type_ = type_;
                this.scattered = scattered;
                this.value = value;
            }

            // Enable comparisons between nil and ldMachoRel struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ldMachoRel value, NilType nil) => value.Equals(default(ldMachoRel));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ldMachoRel value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ldMachoRel value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ldMachoRel value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ldMachoRel(NilType nil) => default(ldMachoRel);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ldMachoRel ldMachoRel_cast(dynamic value)
        {
            return new ldMachoRel(value.addr, value.symnum, value.pcrel, value.length, value.extrn, value.type_, value.scattered, value.value);
        }
    }
}}}}