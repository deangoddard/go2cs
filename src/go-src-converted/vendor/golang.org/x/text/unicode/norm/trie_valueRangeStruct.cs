//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:09:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class norm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct valueRange
        {
            // Constructors
            public valueRange(NilType _)
            {
                this.value = default;
                this.lo = default;
                this.hi = default;
            }

            public valueRange(ushort value = default, byte lo = default, byte hi = default)
            {
                this.value = value;
                this.lo = lo;
                this.hi = hi;
            }

            // Enable comparisons between nil and valueRange struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(valueRange value, NilType nil) => value.Equals(default(valueRange));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(valueRange value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, valueRange value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, valueRange value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator valueRange(NilType nil) => default(valueRange);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static valueRange valueRange_cast(dynamic value)
        {
            return new valueRange(value.value, value.lo, value.hi);
        }
    }
}}}}}}