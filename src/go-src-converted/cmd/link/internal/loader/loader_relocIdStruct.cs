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
        private partial struct relocId
        {
            // Constructors
            public relocId(NilType _)
            {
                this.sym = default;
                this.ridx = default;
            }

            public relocId(Sym sym = default, nint ridx = default)
            {
                this.sym = sym;
                this.ridx = ridx;
            }

            // Enable comparisons between nil and relocId struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(relocId value, NilType nil) => value.Equals(default(relocId));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(relocId value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, relocId value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, relocId value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator relocId(NilType nil) => default(relocId);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static relocId relocId_cast(dynamic value)
        {
            return new relocId(value.sym, value.ridx);
        }
    }
}}}}