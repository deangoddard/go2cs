//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using math = go.math_package;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct emptyInterface
        {
            // Constructors
            public emptyInterface(NilType _)
            {
                this.typ = default;
                this.word = default;
            }

            public emptyInterface(ref ptr<rtype> typ = default, unsafe.Pointer word = default)
            {
                this.typ = typ;
                this.word = word;
            }

            // Enable comparisons between nil and emptyInterface struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(emptyInterface value, NilType nil) => value.Equals(default(emptyInterface));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(emptyInterface value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, emptyInterface value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, emptyInterface value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator emptyInterface(NilType nil) => default(emptyInterface);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static emptyInterface emptyInterface_cast(dynamic value)
        {
            return new emptyInterface(ref value.typ, value.word);
        }
    }
}