//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct UnsupportedTypeError
        {
            // Constructors
            public UnsupportedTypeError(NilType _)
            {
                this.Type = default;
            }

            public UnsupportedTypeError(reflect.Type Type = default)
            {
                this.Type = Type;
            }

            // Enable comparisons between nil and UnsupportedTypeError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnsupportedTypeError value, NilType nil) => value.Equals(default(UnsupportedTypeError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnsupportedTypeError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnsupportedTypeError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnsupportedTypeError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnsupportedTypeError(NilType nil) => default(UnsupportedTypeError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UnsupportedTypeError UnsupportedTypeError_cast(dynamic value)
        {
            return new UnsupportedTypeError(value.Type);
        }
    }
}}