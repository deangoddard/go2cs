//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using math = go.math_package;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nonEmptyInterface
        {
            // Constructors
            public nonEmptyInterface(NilType _)
            {
                this.word = default;
            }

            public nonEmptyInterface(unsafe.Pointer word = default)
            {
                this.word = word;
            }

            // Enable comparisons between nil and nonEmptyInterface struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nonEmptyInterface value, NilType nil) => value.Equals(default(nonEmptyInterface));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nonEmptyInterface value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nonEmptyInterface value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nonEmptyInterface value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nonEmptyInterface(NilType nil) => default(nonEmptyInterface);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nonEmptyInterface nonEmptyInterface_cast(dynamic value)
        {
            return new nonEmptyInterface(value.word);
        }
    }
}