//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:49:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using elf = go.debug.elf_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loadelf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct elfAttribute
        {
            // Constructors
            public elfAttribute(NilType _)
            {
                this.tag = default;
                this.sval = default;
                this.ival = default;
            }

            public elfAttribute(ulong tag = default, @string sval = default, ulong ival = default)
            {
                this.tag = tag;
                this.sval = sval;
                this.ival = ival;
            }

            // Enable comparisons between nil and elfAttribute struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfAttribute value, NilType nil) => value.Equals(default(elfAttribute));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfAttribute value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfAttribute value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfAttribute value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfAttribute(NilType nil) => default(elfAttribute);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static elfAttribute elfAttribute_cast(dynamic value)
        {
            return new elfAttribute(value.tag, value.sval, value.ival);
        }
    }
}}}}