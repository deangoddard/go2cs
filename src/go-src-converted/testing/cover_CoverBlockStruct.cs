//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:47:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using os = go.os_package;
using atomic = go.sync.atomic_package;

#nullable enable

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CoverBlock
        {
            // Constructors
            public CoverBlock(NilType _)
            {
                this.Line0 = default;
                this.Col0 = default;
                this.Line1 = default;
                this.Col1 = default;
                this.Stmts = default;
            }

            public CoverBlock(uint Line0 = default, ushort Col0 = default, uint Line1 = default, ushort Col1 = default, ushort Stmts = default)
            {
                this.Line0 = Line0;
                this.Col0 = Col0;
                this.Line1 = Line1;
                this.Col1 = Col1;
                this.Stmts = Stmts;
            }

            // Enable comparisons between nil and CoverBlock struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CoverBlock value, NilType nil) => value.Equals(default(CoverBlock));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CoverBlock value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CoverBlock value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CoverBlock value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CoverBlock(NilType nil) => default(CoverBlock);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CoverBlock CoverBlock_cast(dynamic value)
        {
            return new CoverBlock(value.Line0, value.Col0, value.Line1, value.Col1, value.Stmts);
        }
    }
}