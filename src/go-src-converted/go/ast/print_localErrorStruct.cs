//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:20:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct localError
        {
            // Constructors
            public localError(NilType _)
            {
                this.err = default;
            }

            public localError(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and localError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(localError value, NilType nil) => value.Equals(default(localError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(localError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, localError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, localError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator localError(NilType nil) => default(localError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static localError localError_cast(dynamic value)
        {
            return new localError(value.err);
        }
    }
}}