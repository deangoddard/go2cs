//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:49:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.compile.@internal.@base_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ir_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Field
        {
            // Constructors
            public Field(NilType _)
            {
                this.Pos = default;
                this.Sym = default;
                this.Ntype = default;
                this.Type = default;
                this.Embedded = default;
                this.IsDDD = default;
                this.Note = default;
                this.Decl = default;
            }

            public Field(src.XPos Pos = default, ref ptr<types.Sym> Sym = default, Ntype Ntype = default, ref ptr<types.Type> Type = default, bool Embedded = default, bool IsDDD = default, @string Note = default, ref ptr<Name> Decl = default)
            {
                this.Pos = Pos;
                this.Sym = Sym;
                this.Ntype = Ntype;
                this.Type = Type;
                this.Embedded = Embedded;
                this.IsDDD = IsDDD;
                this.Note = Note;
                this.Decl = Decl;
            }

            // Enable comparisons between nil and Field struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Field value, NilType nil) => value.Equals(default(Field));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Field value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Field value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Field value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Field(NilType nil) => default(Field);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Field Field_cast(dynamic value)
        {
            return new Field(value.Pos, ref value.Sym, value.Ntype, ref value.Type, value.Embedded, value.IsDDD, value.Note, ref value.Decl);
        }
    }
}}}}