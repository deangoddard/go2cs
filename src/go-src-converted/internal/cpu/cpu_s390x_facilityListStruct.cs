//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class cpu_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct facilityList
        {
            // Constructors
            public facilityList(NilType _)
            {
                this.bits = default;
            }

            public facilityList(array<ulong> bits = default)
            {
                this.bits = bits;
            }

            // Enable comparisons between nil and facilityList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(facilityList value, NilType nil) => value.Equals(default(facilityList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(facilityList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, facilityList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, facilityList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator facilityList(NilType nil) => default(facilityList);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static facilityList facilityList_cast(dynamic value)
        {
            return new facilityList(value.bits);
        }
    }
}}