//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TagPathError
        {
            // Constructors
            public TagPathError(NilType _)
            {
                this.Struct = default;
                this.Field1 = default;
                this.Tag1 = default;
                this.Field2 = default;
                this.Tag2 = default;
            }

            public TagPathError(reflect.Type Struct = default, @string Field1 = default, @string Tag1 = default, @string Field2 = default, @string Tag2 = default)
            {
                this.Struct = Struct;
                this.Field1 = Field1;
                this.Tag1 = Tag1;
                this.Field2 = Field2;
                this.Tag2 = Tag2;
            }

            // Enable comparisons between nil and TagPathError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TagPathError value, NilType nil) => value.Equals(default(TagPathError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TagPathError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TagPathError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TagPathError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TagPathError(NilType nil) => default(TagPathError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TagPathError TagPathError_cast(dynamic value)
        {
            return new TagPathError(value.Struct, value.Field1, value.Tag1, value.Field2, value.Tag2);
        }
    }
}}