//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:42:51 UTC
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
namespace cmd {
namespace @internal
{
    public static partial class src_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct PosTable
        {
            // Constructors
            public PosTable(NilType _)
            {
                this.baseList = default;
                this.indexMap = default;
                this.nameMap = default;
            }

            public PosTable(slice<ptr<PosBase>> baseList = default, map<ptr<PosBase>, nint> indexMap = default, map<@string, nint> nameMap = default)
            {
                this.baseList = baseList;
                this.indexMap = indexMap;
                this.nameMap = nameMap;
            }

            // Enable comparisons between nil and PosTable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PosTable value, NilType nil) => value.Equals(default(PosTable));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PosTable value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PosTable value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PosTable value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PosTable(NilType nil) => default(PosTable);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PosTable PosTable_cast(dynamic value)
        {
            return new PosTable(value.baseList, value.indexMap, value.nameMap);
        }
    }
}}}