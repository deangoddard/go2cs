//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:10:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pageCache
        {
            // Constructors
            public pageCache(NilType _)
            {
                this.@base = default;
                this.cache = default;
                this.scav = default;
            }

            public pageCache(System.UIntPtr @base = default, ulong cache = default, ulong scav = default)
            {
                this.@base = @base;
                this.cache = cache;
                this.scav = scav;
            }

            // Enable comparisons between nil and pageCache struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pageCache value, NilType nil) => value.Equals(default(pageCache));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pageCache value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pageCache value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pageCache value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pageCache(NilType nil) => default(pageCache);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pageCache pageCache_cast(dynamic value)
        {
            return new pageCache(value.@base, value.cache, value.scav);
        }
    }
}