//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:58:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace regexp
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct parser
        {
            // Constructors
            public parser(NilType _)
            {
                this.flags = default;
                this.stack = default;
                this.free = default;
                this.numCap = default;
                this.wholeRegexp = default;
                this.tmpClass = default;
            }

            public parser(Flags flags = default, slice<ptr<Regexp>> stack = default, ref ptr<Regexp> free = default, long numCap = default, @string wholeRegexp = default, slice<int> tmpClass = default)
            {
                this.flags = flags;
                this.stack = stack;
                this.free = free;
                this.numCap = numCap;
                this.wholeRegexp = wholeRegexp;
                this.tmpClass = tmpClass;
            }

            // Enable comparisons between nil and parser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(parser value, NilType nil) => value.Equals(default(parser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(parser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, parser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, parser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator parser(NilType nil) => default(parser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static parser parser_cast(dynamic value)
        {
            return new parser(value.flags, value.stack, ref value.free, value.numCap, value.wholeRegexp, value.tmpClass);
        }
    }
}}