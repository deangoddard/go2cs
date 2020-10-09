//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:00:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using encoding = go.encoding_package;
using base64 = go.encoding.base64_package;
using fmt = go.fmt_package;
using math = go.math_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class json_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct field
        {
            // Constructors
            public field(NilType _)
            {
                this.name = default;
                this.nameBytes = default;
                this.equalFold = default;
                this.nameNonEsc = default;
                this.nameEscHTML = default;
                this.tag = default;
                this.index = default;
                this.typ = default;
                this.omitEmpty = default;
                this.quoted = default;
                this.encoder = default;
            }

            public field(@string name = default, slice<byte> nameBytes = default, Func<slice<byte>, slice<byte>, bool> equalFold = default, @string nameNonEsc = default, @string nameEscHTML = default, bool tag = default, slice<long> index = default, reflect.Type typ = default, bool omitEmpty = default, bool quoted = default, encoderFunc encoder = default)
            {
                this.name = name;
                this.nameBytes = nameBytes;
                this.equalFold = equalFold;
                this.nameNonEsc = nameNonEsc;
                this.nameEscHTML = nameEscHTML;
                this.tag = tag;
                this.index = index;
                this.typ = typ;
                this.omitEmpty = omitEmpty;
                this.quoted = quoted;
                this.encoder = encoder;
            }

            // Enable comparisons between nil and field struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(field value, NilType nil) => value.Equals(default(field));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(field value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, field value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, field value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator field(NilType nil) => default(field);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static field field_cast(dynamic value)
        {
            return new field(value.name, value.nameBytes, value.equalFold, value.nameNonEsc, value.nameEscHTML, value.tag, value.index, value.typ, value.omitEmpty, value.quoted, value.encoder);
        }
    }
}}