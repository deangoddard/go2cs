//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:47:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(@object))]
        public partial struct Var
        {
            // @object structure promotion - sourced from value copy
            private readonly ptr<@object> m_@objectRef;

            private ref @object @object_val => ref m_@objectRef.Value;

            public ref ptr<Scope> parent => ref m_@objectRef.Value.parent;

            public ref token.Pos pos => ref m_@objectRef.Value.pos;

            public ref ptr<Package> pkg => ref m_@objectRef.Value.pkg;

            public ref @string name => ref m_@objectRef.Value.name;

            public ref Type typ => ref m_@objectRef.Value.typ;

            public ref uint order_ => ref m_@objectRef.Value.order_;

            public ref token.Pos scopePos_ => ref m_@objectRef.Value.scopePos_;

            // Constructors
            public Var(NilType _)
            {
                this.@object = default;
                this.anonymous = default;
                this.visited = default;
                this.isField = default;
                this.used = default;
            }

            public Var(object @object = default, bool anonymous = default, bool visited = default, bool isField = default, bool used = default)
            {
                this.@object = @object;
                this.anonymous = anonymous;
                this.visited = visited;
                this.isField = isField;
                this.used = used;
            }

            // Enable comparisons between nil and Var struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Var value, NilType nil) => value.Equals(default(Var));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Var value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Var value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Var value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Var(NilType nil) => default(Var);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Var Var_cast(dynamic value)
        {
            return new Var(value.@object, value.anonymous, value.visited, value.isField, value.used);
        }
    }
}}