//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:22:19 UTC
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
using pe = go.debug.pe_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
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
        private partial struct peSection
        {
            // Constructors
            public peSection(NilType _)
            {
                this.name = default;
                this.shortName = default;
                this.index = default;
                this.virtualSize = default;
                this.virtualAddress = default;
                this.sizeOfRawData = default;
                this.pointerToRawData = default;
                this.pointerToRelocations = default;
                this.numberOfRelocations = default;
                this.characteristics = default;
            }

            public peSection(@string name = default, @string shortName = default, nint index = default, uint virtualSize = default, uint virtualAddress = default, uint sizeOfRawData = default, uint pointerToRawData = default, uint pointerToRelocations = default, ushort numberOfRelocations = default, uint characteristics = default)
            {
                this.name = name;
                this.shortName = shortName;
                this.index = index;
                this.virtualSize = virtualSize;
                this.virtualAddress = virtualAddress;
                this.sizeOfRawData = sizeOfRawData;
                this.pointerToRawData = pointerToRawData;
                this.pointerToRelocations = pointerToRelocations;
                this.numberOfRelocations = numberOfRelocations;
                this.characteristics = characteristics;
            }

            // Enable comparisons between nil and peSection struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(peSection value, NilType nil) => value.Equals(default(peSection));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(peSection value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, peSection value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, peSection value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator peSection(NilType nil) => default(peSection);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static peSection peSection_cast(dynamic value)
        {
            return new peSection(value.name, value.shortName, value.index, value.virtualSize, value.virtualAddress, value.sizeOfRawData, value.pointerToRawData, value.pointerToRelocations, value.numberOfRelocations, value.characteristics);
        }
    }
}}}}