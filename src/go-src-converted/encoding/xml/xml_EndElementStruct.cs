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
        public partial struct EndElement
        {
            // Constructors
            public EndElement(NilType _)
            {
                this.Name = default;
            }

            public EndElement(Name Name = default)
            {
                this.Name = Name;
            }

            // Enable comparisons between nil and EndElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EndElement value, NilType nil) => value.Equals(default(EndElement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EndElement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EndElement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EndElement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EndElement(NilType nil) => default(EndElement);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static EndElement EndElement_cast(dynamic value)
        {
            return new EndElement(value.Name);
        }
    }
}}