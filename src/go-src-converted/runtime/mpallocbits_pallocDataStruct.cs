//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sys = go.runtime.@internal.sys_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct pallocData
        {
            // Constructors
            public pallocData(NilType _)
            {
                this.pallocBits = default;
                this.scavenged = default;
            }

            public pallocData(pallocBits pallocBits = default, pageBits scavenged = default)
            {
                this.pallocBits = pallocBits;
                this.scavenged = scavenged;
            }

            // Enable comparisons between nil and pallocData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pallocData value, NilType nil) => value.Equals(default(pallocData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pallocData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pallocData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pallocData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pallocData(NilType nil) => default(pallocData);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static pallocData pallocData_cast(dynamic value)
        {
            return new pallocData(value.pallocBits, value.scavenged);
        }
    }
}