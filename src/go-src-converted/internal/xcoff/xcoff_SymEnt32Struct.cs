//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SymEnt32
        {
            // Constructors
            public SymEnt32(NilType _)
            {
                this.Nname = default;
                this.Nvalue = default;
                this.Nscnum = default;
                this.Ntype = default;
                this.Nsclass = default;
                this.Nnumaux = default;
            }

            public SymEnt32(array<byte> Nname = default, uint Nvalue = default, short Nscnum = default, ushort Ntype = default, sbyte Nsclass = default, sbyte Nnumaux = default)
            {
                this.Nname = Nname;
                this.Nvalue = Nvalue;
                this.Nscnum = Nscnum;
                this.Ntype = Ntype;
                this.Nsclass = Nsclass;
                this.Nnumaux = Nnumaux;
            }

            // Enable comparisons between nil and SymEnt32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SymEnt32 value, NilType nil) => value.Equals(default(SymEnt32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SymEnt32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SymEnt32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SymEnt32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymEnt32(NilType nil) => default(SymEnt32);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SymEnt32 SymEnt32_cast(dynamic value)
        {
            return new SymEnt32(value.Nname, value.Nvalue, value.Nscnum, value.Ntype, value.Nsclass, value.Nnumaux);
        }
    }
}}