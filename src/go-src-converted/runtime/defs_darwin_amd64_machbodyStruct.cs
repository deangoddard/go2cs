//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct machbody
        {
            // Constructors
            public machbody(NilType _)
            {
                this.msgh_descriptor_count = default;
            }

            public machbody(uint msgh_descriptor_count = default)
            {
                this.msgh_descriptor_count = msgh_descriptor_count;
            }

            // Enable comparisons between nil and machbody struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machbody value, NilType nil) => value.Equals(default(machbody));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machbody value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machbody value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machbody value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machbody(NilType nil) => default(machbody);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static machbody machbody_cast(dynamic value)
        {
            return new machbody(value.msgh_descriptor_count);
        }
    }
}