//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:18:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using subtleoverlap = go.crypto.@internal.subtle_package;
using subtle = go.crypto.subtle_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using go;

#nullable enable

namespace go {
namespace crypto
{
    public static partial class cipher_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gcmFieldElement
        {
            // Constructors
            public gcmFieldElement(NilType _)
            {
                this.low = default;
                this.high = default;
            }

            public gcmFieldElement(ulong low = default, ulong high = default)
            {
                this.low = low;
                this.high = high;
            }

            // Enable comparisons between nil and gcmFieldElement struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gcmFieldElement value, NilType nil) => value.Equals(default(gcmFieldElement));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gcmFieldElement value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gcmFieldElement value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gcmFieldElement value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gcmFieldElement(NilType nil) => default(gcmFieldElement);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static gcmFieldElement gcmFieldElement_cast(dynamic value)
        {
            return new gcmFieldElement(value.low, value.high);
        }
    }
}}