//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace math
{
    public static partial class rand_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rand
        {
            // Constructors
            public Rand(NilType _)
            {
                this.src = default;
                this.s64 = default;
                this.readVal = default;
                this.readPos = default;
            }

            public Rand(Source src = default, Source64 s64 = default, long readVal = default, sbyte readPos = default)
            {
                this.src = src;
                this.s64 = s64;
                this.readVal = readVal;
                this.readPos = readPos;
            }

            // Enable comparisons between nil and Rand struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rand value, NilType nil) => value.Equals(default(Rand));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rand value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rand value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rand value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rand(NilType nil) => default(Rand);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rand Rand_cast(dynamic value)
        {
            return new Rand(value.src, value.s64, value.readVal, value.readPos);
        }
    }
}}