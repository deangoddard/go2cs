//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:26:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using syntax = go.cmd.compile.@internal.syntax_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types2_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(@object))]
        public partial struct PkgName
        {
            // @object structure promotion - sourced from value copy
            private readonly ptr<@object> m_@objectRef;

            private ref @object @object_val => ref m_@objectRef.Value;

            public ref ptr<Scope> parent => ref m_@objectRef.Value.parent;

            public ref syntax.Pos pos => ref m_@objectRef.Value.pos;

            public ref ptr<Package> pkg => ref m_@objectRef.Value.pkg;

            public ref @string name => ref m_@objectRef.Value.name;

            public ref Type typ => ref m_@objectRef.Value.typ;

            public ref uint order_ => ref m_@objectRef.Value.order_;

            public ref color color_ => ref m_@objectRef.Value.color_;

            public ref syntax.Pos scopePos_ => ref m_@objectRef.Value.scopePos_;

            // Constructors
            public PkgName(NilType _)
            {
                this.@object = default;
                this.imported = default;
                this.used = default;
            }

            public PkgName(object @object = default, ref ptr<Package> imported = default, bool used = default)
            {
                this.@object = @object;
                this.imported = imported;
                this.used = used;
            }

            // Enable comparisons between nil and PkgName struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PkgName value, NilType nil) => value.Equals(default(PkgName));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PkgName value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PkgName value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PkgName value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PkgName(NilType nil) => default(PkgName);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static PkgName PkgName_cast(dynamic value)
        {
            return new PkgName(value.@object, ref value.imported, value.used);
        }
    }
}}}}