//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:24:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using fmt = go.fmt_package;
using atomic = go.sync.atomic_package;
using _@unsafe_ = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Region
        {
            // Constructors
            public Region(NilType _)
            {
                this.id = default;
                this.regionType = default;
            }

            public Region(ulong id = default, @string regionType = default)
            {
                this.id = id;
                this.regionType = regionType;
            }

            // Enable comparisons between nil and Region struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Region value, NilType nil) => value.Equals(default(Region));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Region value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Region value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Region value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Region(NilType nil) => default(Region);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Region Region_cast(dynamic value)
        {
            return new Region(value.id, value.regionType);
        }
    }
}}