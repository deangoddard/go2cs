//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:10:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mts
        {
            // Constructors
            public mts(NilType _)
            {
                this.tv_sec = default;
                this.tv_nsec = default;
            }

            public mts(long tv_sec = default, long tv_nsec = default)
            {
                this.tv_sec = tv_sec;
                this.tv_nsec = tv_nsec;
            }

            // Enable comparisons between nil and mts struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mts value, NilType nil) => value.Equals(default(mts));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mts value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mts value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mts value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mts(NilType nil) => default(mts);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mts mts_cast(dynamic value)
        {
            return new mts(value.tv_sec, value.tv_nsec);
        }
    }
}