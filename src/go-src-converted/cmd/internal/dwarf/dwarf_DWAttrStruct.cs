//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:51:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class dwarf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct DWAttr
        {
            // Constructors
            public DWAttr(NilType _)
            {
                this.Link = default;
                this.Atr = default;
                this.Cls = default;
                this.Value = default;
            }

            public DWAttr(ref ptr<DWAttr> Link = default, ushort Atr = default, byte Cls = default, long Value = default)
            {
                this.Link = Link;
                this.Atr = Atr;
                this.Cls = Cls;
                this.Value = Value;
            }

            // Enable comparisons between nil and DWAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DWAttr value, NilType nil) => value.Equals(default(DWAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DWAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DWAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DWAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DWAttr(NilType nil) => default(DWAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DWAttr DWAttr_cast(dynamic value)
        {
            return new DWAttr(ref value.Link, value.Atr, value.Cls, value.Value);
        }
    }
}}}