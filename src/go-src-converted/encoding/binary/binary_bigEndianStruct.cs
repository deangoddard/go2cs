//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:21:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace encoding
{
    public static partial class binary_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bigEndian
        {
            // Constructors
            public bigEndian(NilType _)
            {
            }
            // Enable comparisons between nil and bigEndian struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bigEndian value, NilType nil) => value.Equals(default(bigEndian));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bigEndian value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bigEndian value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bigEndian value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bigEndian(NilType nil) => default(bigEndian);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bigEndian bigEndian_cast(dynamic value)
        {
            return new bigEndian();
        }
    }
}}