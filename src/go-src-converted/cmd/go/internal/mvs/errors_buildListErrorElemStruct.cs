//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:31:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using strings = go.strings_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class mvs_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct buildListErrorElem
        {
            // Constructors
            public buildListErrorElem(NilType _)
            {
                this.m = default;
                this.nextReason = default;
            }

            public buildListErrorElem(module.Version m = default, @string nextReason = default)
            {
                this.m = m;
                this.nextReason = nextReason;
            }

            // Enable comparisons between nil and buildListErrorElem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(buildListErrorElem value, NilType nil) => value.Equals(default(buildListErrorElem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(buildListErrorElem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, buildListErrorElem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, buildListErrorElem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator buildListErrorElem(NilType nil) => default(buildListErrorElem);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static buildListErrorElem buildListErrorElem_cast(dynamic value)
        {
            return new buildListErrorElem(value.m, value.nextReason);
        }
    }
}}}}