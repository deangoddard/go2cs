//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:33:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using goobj = go.cmd.@internal.goobj_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.link.@internal.sym_package;
using elf = go.debug.elf_package;
using fmt = go.fmt_package;
using log = go.log_package;
using bits = go.math.bits_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct objSym
        {
            // Constructors
            public objSym(NilType _)
            {
                this.objidx = default;
                this.s = default;
            }

            public objSym(uint objidx = default, uint s = default)
            {
                this.objidx = objidx;
                this.s = s;
            }

            // Enable comparisons between nil and objSym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(objSym value, NilType nil) => value.Equals(default(objSym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(objSym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, objSym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, objSym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator objSym(NilType nil) => default(objSym);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static objSym objSym_cast(dynamic value)
        {
            return new objSym(value.objidx, value.s);
        }
    }
}}}}