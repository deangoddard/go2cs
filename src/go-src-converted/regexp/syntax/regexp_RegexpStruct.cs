//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:23:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using go;

#nullable enable

namespace go {
namespace regexp
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Regexp
        {
            // Constructors
            public Regexp(NilType _)
            {
                this.Op = default;
                this.Flags = default;
                this.Sub = default;
                this.Sub0 = default;
                this.Rune = default;
                this.Rune0 = default;
                this.Min = default;
                this.Max = default;
                this.Cap = default;
                this.Name = default;
            }

            public Regexp(Op Op = default, Flags Flags = default, slice<ptr<Regexp>> Sub = default, array<ptr<Regexp>> Sub0 = default, slice<int> Rune = default, array<int> Rune0 = default, nint Min = default, nint Max = default, nint Cap = default, @string Name = default)
            {
                this.Op = Op;
                this.Flags = Flags;
                this.Sub = Sub;
                this.Sub0 = Sub0;
                this.Rune = Rune;
                this.Rune0 = Rune0;
                this.Min = Min;
                this.Max = Max;
                this.Cap = Cap;
                this.Name = Name;
            }

            // Enable comparisons between nil and Regexp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Regexp value, NilType nil) => value.Equals(default(Regexp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Regexp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Regexp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Regexp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Regexp(NilType nil) => default(Regexp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Regexp Regexp_cast(dynamic value)
        {
            return new Regexp(value.Op, value.Flags, value.Sub, value.Sub0, value.Rune, value.Rune0, value.Min, value.Max, value.Cap, value.Name);
        }
    }
}}