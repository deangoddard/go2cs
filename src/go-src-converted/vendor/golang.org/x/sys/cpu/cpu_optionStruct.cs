//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using os = go.os_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class cpu_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct option
        {
            // Constructors
            public option(NilType _)
            {
                this.Name = default;
                this.Feature = default;
                this.Specified = default;
                this.Enable = default;
                this.Required = default;
            }

            public option(@string Name = default, ref ptr<bool> Feature = default, bool Specified = default, bool Enable = default, bool Required = default)
            {
                this.Name = Name;
                this.Feature = Feature;
                this.Specified = Specified;
                this.Enable = Enable;
                this.Required = Required;
            }

            // Enable comparisons between nil and option struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(option value, NilType nil) => value.Equals(default(option));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(option value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, option value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, option value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator option(NilType nil) => default(option);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static option option_cast(dynamic value)
        {
            return new option(value.Name, ref value.Feature, value.Specified, value.Enable, value.Required);
        }
    }
}}}}}