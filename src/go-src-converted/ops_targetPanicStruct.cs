//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;
using ssa = go.golang.org.x.tools.go.ssa_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace ssa
{
    public static partial class interp_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct targetPanic
        {
            // Constructors
            public targetPanic(NilType _)
            {
                this.v = default;
            }

            public targetPanic(value v = default)
            {
                this.v = v;
            }

            // Enable comparisons between nil and targetPanic struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(targetPanic value, NilType nil) => value.Equals(default(targetPanic));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(targetPanic value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, targetPanic value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, targetPanic value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator targetPanic(NilType nil) => default(targetPanic);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static targetPanic targetPanic_cast(dynamic value)
        {
            return new targetPanic(value.v);
        }
    }
}}}}}}