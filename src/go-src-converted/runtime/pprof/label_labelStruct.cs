//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using context = go.context_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct label
        {
            // Constructors
            public label(NilType _)
            {
                this.key = default;
                this.value = default;
            }

            public label(@string key = default, @string value = default)
            {
                this.key = key;
                this.value = value;
            }

            // Enable comparisons between nil and label struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(label value, NilType nil) => value.Equals(default(label));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(label value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, label value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, label value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator label(NilType nil) => default(label);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static label label_cast(dynamic value)
        {
            return new label(value.key, value.value);
        }
    }
}}