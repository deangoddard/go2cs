//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct machTimebaseInfo
        {
            // Constructors
            public machTimebaseInfo(NilType _)
            {
                this.numer = default;
                this.denom = default;
            }

            public machTimebaseInfo(uint numer = default, uint denom = default)
            {
                this.numer = numer;
                this.denom = denom;
            }

            // Enable comparisons between nil and machTimebaseInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machTimebaseInfo value, NilType nil) => value.Equals(default(machTimebaseInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machTimebaseInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machTimebaseInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machTimebaseInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machTimebaseInfo(NilType nil) => default(machTimebaseInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static machTimebaseInfo machTimebaseInfo_cast(dynamic value)
        {
            return new machTimebaseInfo(value.numer, value.denom);
        }
    }
}