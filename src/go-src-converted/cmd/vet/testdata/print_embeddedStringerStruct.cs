//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using math = go.math_package;
using os = go.os_package;
using testing = go.testing_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vet
{
    public static partial class testdata_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct embeddedStringer
        {
            // Constructors
            public embeddedStringer(NilType _)
            {
                this.foo = default;
                this.ptrStringer = default;
                this.bar = default;
            }

            public embeddedStringer(@string foo = default, ptrStringer ptrStringer = default, long bar = default)
            {
                this.foo = foo;
                this.ptrStringer = ptrStringer;
                this.bar = bar;
            }

            // Enable comparisons between nil and embeddedStringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(embeddedStringer value, NilType nil) => value.Equals(default(embeddedStringer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(embeddedStringer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, embeddedStringer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, embeddedStringer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator embeddedStringer(NilType nil) => default(embeddedStringer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static embeddedStringer embeddedStringer_cast(dynamic value)
        {
            return new embeddedStringer(value.foo, value.ptrStringer, value.bar);
        }
    }
}}}