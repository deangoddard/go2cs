//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:39:52 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct UnsupportedValueError
        {
            // Constructors
            public UnsupportedValueError(NilType _)
            {
                this.Value = default;
                this.Str = default;
            }

            public UnsupportedValueError(reflect.Value Value = default, @string Str = default)
            {
                this.Value = Value;
                this.Str = Str;
            }

            // Enable comparisons between nil and UnsupportedValueError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnsupportedValueError value, NilType nil) => value.Equals(default(UnsupportedValueError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnsupportedValueError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnsupportedValueError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnsupportedValueError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnsupportedValueError(NilType nil) => default(UnsupportedValueError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static UnsupportedValueError UnsupportedValueError_cast(dynamic value)
        {
            return new UnsupportedValueError(value.Value, value.Str);
        }
    }
}}