//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:50:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using big = go.math.big_package;
using bits = go.math.bits_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct smagicData
        {
            // Constructors
            public smagicData(NilType _)
            {
                this.s = default;
                this.m = default;
            }

            public smagicData(long s = default, ulong m = default)
            {
                this.s = s;
                this.m = m;
            }

            // Enable comparisons between nil and smagicData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(smagicData value, NilType nil) => value.Equals(default(smagicData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(smagicData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, smagicData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, smagicData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator smagicData(NilType nil) => default(smagicData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static smagicData smagicData_cast(dynamic value)
        {
            return new smagicData(value.s, value.m);
        }
    }
}}}}