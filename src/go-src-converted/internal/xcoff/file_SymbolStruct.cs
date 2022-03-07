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
        public partial struct Symbol
        {
            // Constructors
            public Symbol(NilType _)
            {
                this.Name = default;
                this.Value = default;
                this.SectionNumber = default;
                this.StorageClass = default;
                this.AuxFcn = default;
                this.AuxCSect = default;
            }

            public Symbol(@string Name = default, ulong Value = default, nint SectionNumber = default, nint StorageClass = default, AuxiliaryFcn AuxFcn = default, AuxiliaryCSect AuxCSect = default)
            {
                this.Name = Name;
                this.Value = Value;
                this.SectionNumber = SectionNumber;
                this.StorageClass = StorageClass;
                this.AuxFcn = AuxFcn;
                this.AuxCSect = AuxCSect;
            }

            // Enable comparisons between nil and Symbol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Symbol value, NilType nil) => value.Equals(default(Symbol));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Symbol value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Symbol value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Symbol value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Symbol(NilType nil) => default(Symbol);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Symbol Symbol_cast(dynamic value)
        {
            return new Symbol(value.Name, value.Value, value.SectionNumber, value.StorageClass, value.AuxFcn, value.AuxCSect);
        }
    }
}}