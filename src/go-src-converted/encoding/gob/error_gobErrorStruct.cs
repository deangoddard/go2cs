//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:35:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gobError
        {
            // Constructors
            public gobError(NilType _)
            {
                this.err = default;
            }

            public gobError(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and gobError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gobError value, NilType nil) => value.Equals(default(gobError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gobError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gobError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gobError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gobError(NilType nil) => default(gobError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gobError gobError_cast(dynamic value)
        {
            return new gobError(value.err);
        }
    }
}}