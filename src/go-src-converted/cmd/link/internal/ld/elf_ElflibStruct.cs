//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using elf = go.debug.elf_package;
using binary = go.encoding.binary_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Elflib
        {
            // Constructors
            public Elflib(NilType _)
            {
                this.next = default;
                this.aux = default;
                this.file = default;
            }

            public Elflib(ref ptr<Elflib> next = default, ref ptr<Elfaux> aux = default, @string file = default)
            {
                this.next = next;
                this.aux = aux;
                this.file = file;
            }

            // Enable comparisons between nil and Elflib struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Elflib value, NilType nil) => value.Equals(default(Elflib));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Elflib value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Elflib value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Elflib value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Elflib(NilType nil) => default(Elflib);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Elflib Elflib_cast(dynamic value)
        {
            return new Elflib(ref value.next, ref value.aux, value.file);
        }
    }
}}}}