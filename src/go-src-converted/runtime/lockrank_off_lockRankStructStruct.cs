//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:24:34 UTC
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
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct lockRankStruct
        {
            // Constructors
            public lockRankStruct(NilType _)
            {
            }
            // Enable comparisons between nil and lockRankStruct struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lockRankStruct value, NilType nil) => value.Equals(default(lockRankStruct));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lockRankStruct value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lockRankStruct value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lockRankStruct value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lockRankStruct(NilType nil) => default(lockRankStruct);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static lockRankStruct lockRankStruct_cast(dynamic value)
        {
            return new lockRankStruct();
        }
    }
}