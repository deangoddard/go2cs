//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:42:56 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct percentDStruct
        {
            // Constructors
            public percentDStruct(NilType _)
            {
                this.a = default;
                this.b = default;
                this.c = default;
            }

            public percentDStruct(nint a = default, slice<byte> b = default, ref ptr<double> c = default)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            // Enable comparisons between nil and percentDStruct struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(percentDStruct value, NilType nil) => value.Equals(default(percentDStruct));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(percentDStruct value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, percentDStruct value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, percentDStruct value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator percentDStruct(NilType nil) => default(percentDStruct);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static percentDStruct percentDStruct_cast(dynamic value)
        {
            return new percentDStruct(value.a, value.b, ref value.c);
        }
    }
}}}}