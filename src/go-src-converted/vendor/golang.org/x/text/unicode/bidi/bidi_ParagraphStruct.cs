//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Paragraph
        {
            // Constructors
            public Paragraph(NilType _)
            {
                this.p = default;
                this.o = default;
                this.opts = default;
                this.types = default;
                this.pairTypes = default;
                this.pairValues = default;
                this.runes = default;
                this.options = default;
            }

            public Paragraph(slice<byte> p = default, Ordering o = default, slice<Option> opts = default, slice<Class> types = default, slice<bracketType> pairTypes = default, slice<int> pairValues = default, slice<int> runes = default, options options = default)
            {
                this.p = p;
                this.o = o;
                this.opts = opts;
                this.types = types;
                this.pairTypes = pairTypes;
                this.pairValues = pairValues;
                this.runes = runes;
                this.options = options;
            }

            // Enable comparisons between nil and Paragraph struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Paragraph value, NilType nil) => value.Equals(default(Paragraph));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Paragraph value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Paragraph value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Paragraph value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Paragraph(NilType nil) => default(Paragraph);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Paragraph Paragraph_cast(dynamic value)
        {
            return new Paragraph(value.p, value.o, value.opts, value.types, value.pairTypes, value.pairValues, value.runes, value.options);
        }
    }
}}}}}}