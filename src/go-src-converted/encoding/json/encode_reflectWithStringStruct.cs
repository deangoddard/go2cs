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
        private partial struct reflectWithString
        {
            // Constructors
            public reflectWithString(NilType _)
            {
                this.k = default;
                this.v = default;
                this.ks = default;
            }

            public reflectWithString(reflect.Value k = default, reflect.Value v = default, @string ks = default)
            {
                this.k = k;
                this.v = v;
                this.ks = ks;
            }

            // Enable comparisons between nil and reflectWithString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reflectWithString value, NilType nil) => value.Equals(default(reflectWithString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reflectWithString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reflectWithString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reflectWithString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator reflectWithString(NilType nil) => default(reflectWithString);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static reflectWithString reflectWithString_cast(dynamic value)
        {
            return new reflectWithString(value.k, value.v, value.ks);
        }
    }
}}