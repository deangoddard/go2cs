//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:15:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using math = go.math_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct deflateFast
        {
            // Constructors
            public deflateFast(NilType _)
            {
                this.table = default;
                this.prev = default;
                this.cur = default;
            }

            public deflateFast(array<tableEntry> table = default, slice<byte> prev = default, int cur = default)
            {
                this.table = table;
                this.prev = prev;
                this.cur = cur;
            }

            // Enable comparisons between nil and deflateFast struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(deflateFast value, NilType nil) => value.Equals(default(deflateFast));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(deflateFast value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, deflateFast value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, deflateFast value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator deflateFast(NilType nil) => default(deflateFast);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static deflateFast deflateFast_cast(dynamic value)
        {
            return new deflateFast(value.table, value.prev, value.cur);
        }
    }
}}