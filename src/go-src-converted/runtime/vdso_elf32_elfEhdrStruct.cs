//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct elfEhdr
        {
            // Constructors
            public elfEhdr(NilType _)
            {
                this.e_ident = default;
                this.e_type = default;
                this.e_machine = default;
                this.e_version = default;
                this.e_entry = default;
                this.e_phoff = default;
                this.e_shoff = default;
                this.e_flags = default;
                this.e_ehsize = default;
                this.e_phentsize = default;
                this.e_phnum = default;
                this.e_shentsize = default;
                this.e_shnum = default;
                this.e_shstrndx = default;
            }

            public elfEhdr(array<byte> e_ident = default, ushort e_type = default, ushort e_machine = default, uint e_version = default, uint e_entry = default, uint e_phoff = default, uint e_shoff = default, uint e_flags = default, ushort e_ehsize = default, ushort e_phentsize = default, ushort e_phnum = default, ushort e_shentsize = default, ushort e_shnum = default, ushort e_shstrndx = default)
            {
                this.e_ident = e_ident;
                this.e_type = e_type;
                this.e_machine = e_machine;
                this.e_version = e_version;
                this.e_entry = e_entry;
                this.e_phoff = e_phoff;
                this.e_shoff = e_shoff;
                this.e_flags = e_flags;
                this.e_ehsize = e_ehsize;
                this.e_phentsize = e_phentsize;
                this.e_phnum = e_phnum;
                this.e_shentsize = e_shentsize;
                this.e_shnum = e_shnum;
                this.e_shstrndx = e_shstrndx;
            }

            // Enable comparisons between nil and elfEhdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(elfEhdr value, NilType nil) => value.Equals(default(elfEhdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(elfEhdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, elfEhdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, elfEhdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator elfEhdr(NilType nil) => default(elfEhdr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static elfEhdr elfEhdr_cast(dynamic value)
        {
            return new elfEhdr(value.e_ident, value.e_type, value.e_machine, value.e_version, value.e_entry, value.e_phoff, value.e_shoff, value.e_flags, value.e_ehsize, value.e_phentsize, value.e_phnum, value.e_shentsize, value.e_shnum, value.e_shstrndx);
        }
    }
}