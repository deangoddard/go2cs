//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:41 UTC
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
        private partial struct elfAttributeList
        {
            // Constructors
            public elfAttributeList(NilType _)
            {
                this.data = default;
                this.err = default;
            }

            public elfAttributeList(slice<byte> data = default, error err = default)
            {
                this.data = data;
                this.err = err;
            }

            // Enable comparisons between nil and elfAttributeList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfAttributeList value, NilType nil) => value.Equals(default(elfAttributeList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfAttributeList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfAttributeList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfAttributeList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfAttributeList(NilType nil) => default(elfAttributeList);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static elfAttributeList elfAttributeList_cast(dynamic value)
        {
            return new elfAttributeList(value.data, value.err);
        }
    }
}}}}