//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:38:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct sampleKey
        {
            // Constructors
            public sampleKey(NilType _)
            {
                this.locations = default;
                this.labels = default;
                this.numlabels = default;
            }

            public sampleKey(@string locations = default, @string labels = default, @string numlabels = default)
            {
                this.locations = locations;
                this.labels = labels;
                this.numlabels = numlabels;
            }

            // Enable comparisons between nil and sampleKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sampleKey value, NilType nil) => value.Equals(default(sampleKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sampleKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sampleKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sampleKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sampleKey(NilType nil) => default(sampleKey);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static sampleKey sampleKey_cast(dynamic value)
        {
            return new sampleKey(value.locations, value.labels, value.numlabels);
        }
    }
}}