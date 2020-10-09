//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class strings_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringFinder
        {
            // Constructors
            public stringFinder(NilType _)
            {
                this.pattern = default;
                this.badCharSkip = default;
                this.goodSuffixSkip = default;
            }

            public stringFinder(@string pattern = default, array<long> badCharSkip = default, slice<long> goodSuffixSkip = default)
            {
                this.pattern = pattern;
                this.badCharSkip = badCharSkip;
                this.goodSuffixSkip = goodSuffixSkip;
            }

            // Enable comparisons between nil and stringFinder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringFinder value, NilType nil) => value.Equals(default(stringFinder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringFinder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringFinder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringFinder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringFinder(NilType nil) => default(stringFinder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stringFinder stringFinder_cast(dynamic value)
        {
            return new stringFinder(value.pattern, value.badCharSkip, value.goodSuffixSkip);
        }
    }
}