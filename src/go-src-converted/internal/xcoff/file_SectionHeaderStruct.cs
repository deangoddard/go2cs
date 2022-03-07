//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using dwarf = go.debug.dwarf_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SectionHeader
        {
            // Constructors
            public SectionHeader(NilType _)
            {
                this.Name = default;
                this.VirtualAddress = default;
                this.Size = default;
                this.Type = default;
                this.Relptr = default;
                this.Nreloc = default;
            }

            public SectionHeader(@string Name = default, ulong VirtualAddress = default, ulong Size = default, uint Type = default, ulong Relptr = default, uint Nreloc = default)
            {
                this.Name = Name;
                this.VirtualAddress = VirtualAddress;
                this.Size = Size;
                this.Type = Type;
                this.Relptr = Relptr;
                this.Nreloc = Nreloc;
            }

            // Enable comparisons between nil and SectionHeader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SectionHeader value, NilType nil) => value.Equals(default(SectionHeader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SectionHeader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SectionHeader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SectionHeader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SectionHeader(NilType nil) => default(SectionHeader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SectionHeader SectionHeader_cast(dynamic value)
        {
            return new SectionHeader(value.Name, value.VirtualAddress, value.Size, value.Type, value.Relptr, value.Nreloc);
        }
    }
}}