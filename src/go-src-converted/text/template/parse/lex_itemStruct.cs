//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace text {
namespace template
{
    public static partial class parse_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct item
        {
            // Constructors
            public item(NilType _)
            {
                this.typ = default;
                this.pos = default;
                this.val = default;
                this.line = default;
            }

            public item(itemType typ = default, Pos pos = default, @string val = default, nint line = default)
            {
                this.typ = typ;
                this.pos = pos;
                this.val = val;
                this.line = line;
            }

            // Enable comparisons between nil and item struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(item value, NilType nil) => value.Equals(default(item));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(item value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, item value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, item value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator item(NilType nil) => default(item);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static item item_cast(dynamic value)
        {
            return new item(value.typ, value.pos, value.val, value.line);
        }
    }
}}}