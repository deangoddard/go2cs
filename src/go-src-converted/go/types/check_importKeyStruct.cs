//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct importKey
        {
            // Constructors
            public importKey(NilType _)
            {
                this.path = default;
                this.dir = default;
            }

            public importKey(@string path = default, @string dir = default)
            {
                this.path = path;
                this.dir = dir;
            }

            // Enable comparisons between nil and importKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importKey value, NilType nil) => value.Equals(default(importKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importKey(NilType nil) => default(importKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importKey importKey_cast(dynamic value)
        {
            return new importKey(value.path, value.dir);
        }
    }
}}