//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using logpkg = go.log_package;
using math = go.math_package;
using os = go.os_package;
using testing = go.testing_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class print_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct notstringer
        {
            // Constructors
            public notstringer(NilType _)
            {
                this.f = default;
            }

            public notstringer(double f = default)
            {
                this.f = f;
            }

            // Enable comparisons between nil and notstringer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(notstringer value, NilType nil) => value.Equals(default(notstringer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(notstringer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, notstringer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, notstringer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator notstringer(NilType nil) => default(notstringer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static notstringer notstringer_cast(dynamic value)
        {
            return new notstringer(value.f);
        }
    }
}}}}