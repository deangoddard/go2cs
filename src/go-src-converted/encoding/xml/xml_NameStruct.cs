//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:36 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Name
        {
            // Constructors
            public Name(NilType _)
            {
                this.Space = default;
                this.Local = default;
            }

            public Name(@string Space = default, @string Local = default)
            {
                this.Space = Space;
                this.Local = Local;
            }

            // Enable comparisons between nil and Name struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Name value, NilType nil) => value.Equals(default(Name));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Name value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Name value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Name value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Name(NilType nil) => default(Name);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Name Name_cast(dynamic value)
        {
            return new Name(value.Space, value.Local);
        }
    }
}}