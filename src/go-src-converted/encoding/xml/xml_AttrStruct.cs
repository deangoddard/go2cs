//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Attr
        {
            // Constructors
            public Attr(NilType _)
            {
                this.Name = default;
                this.Value = default;
            }

            public Attr(Name Name = default, @string Value = default)
            {
                this.Name = Name;
                this.Value = Value;
            }

            // Enable comparisons between nil and Attr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Attr value, NilType nil) => value.Equals(default(Attr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Attr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Attr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Attr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Attr(NilType nil) => default(Attr);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Attr Attr_cast(dynamic value)
        {
            return new Attr(value.Name, value.Value);
        }
    }
}}