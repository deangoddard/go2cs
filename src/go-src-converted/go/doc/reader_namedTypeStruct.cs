//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using token = go.go.token_package;
using lazyregexp = go.@internal.lazyregexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class doc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct namedType
        {
            // Constructors
            public namedType(NilType _)
            {
                this.doc = default;
                this.name = default;
                this.decl = default;
                this.isEmbedded = default;
                this.isStruct = default;
                this.embedded = default;
                this.values = default;
                this.funcs = default;
                this.methods = default;
            }

            public namedType(@string doc = default, @string name = default, ref ptr<ast.GenDecl> decl = default, bool isEmbedded = default, bool isStruct = default, embeddedSet embedded = default, slice<ptr<Value>> values = default, methodSet funcs = default, methodSet methods = default)
            {
                this.doc = doc;
                this.name = name;
                this.decl = decl;
                this.isEmbedded = isEmbedded;
                this.isStruct = isStruct;
                this.embedded = embedded;
                this.values = values;
                this.funcs = funcs;
                this.methods = methods;
            }

            // Enable comparisons between nil and namedType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(namedType value, NilType nil) => value.Equals(default(namedType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(namedType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, namedType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, namedType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator namedType(NilType nil) => default(namedType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static namedType namedType_cast(dynamic value)
        {
            return new namedType(value.doc, value.name, ref value.decl, value.isEmbedded, value.isStruct, value.embedded, value.values, value.funcs, value.methods);
        }
    }
}}