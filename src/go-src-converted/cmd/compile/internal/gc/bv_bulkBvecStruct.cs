//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:40:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bits = go.math.bits_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bulkBvec
        {
            // Constructors
            public bulkBvec(NilType _)
            {
                this.words = default;
                this.nbit = default;
                this.nword = default;
            }

            public bulkBvec(slice<uint> words = default, int nbit = default, int nword = default)
            {
                this.words = words;
                this.nbit = nbit;
                this.nword = nword;
            }

            // Enable comparisons between nil and bulkBvec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bulkBvec value, NilType nil) => value.Equals(default(bulkBvec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bulkBvec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bulkBvec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bulkBvec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bulkBvec(NilType nil) => default(bulkBvec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bulkBvec bulkBvec_cast(dynamic value)
        {
            return new bulkBvec(value.words, value.nbit, value.nword);
        }
    }
}}}}