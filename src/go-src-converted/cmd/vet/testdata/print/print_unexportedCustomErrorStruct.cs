//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        private partial struct unexportedCustomError
        {
            // Constructors
            public unexportedCustomError(NilType _)
            {
                this.e = default;
            }

            public unexportedCustomError(errorer e = default)
            {
                this.e = e;
            }

            // Enable comparisons between nil and unexportedCustomError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(unexportedCustomError value, NilType nil) => value.Equals(default(unexportedCustomError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(unexportedCustomError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, unexportedCustomError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, unexportedCustomError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator unexportedCustomError(NilType nil) => default(unexportedCustomError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static unexportedCustomError unexportedCustomError_cast(dynamic value)
        {
            return new unexportedCustomError(value.e);
        }
    }
}}}}