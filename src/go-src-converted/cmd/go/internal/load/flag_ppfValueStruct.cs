//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:16:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @base = go.cmd.go.@internal.@base_package;
using str = go.cmd.go.@internal.str_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ppfValue
        {
            // Constructors
            public ppfValue(NilType _)
            {
                this.match = default;
                this.flags = default;
            }

            public ppfValue(Func<ptr<Package>, bool> match = default, slice<@string> flags = default)
            {
                this.match = match;
                this.flags = flags;
            }

            // Enable comparisons between nil and ppfValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ppfValue value, NilType nil) => value.Equals(default(ppfValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ppfValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ppfValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ppfValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ppfValue(NilType nil) => default(ppfValue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ppfValue ppfValue_cast(dynamic value)
        {
            return new ppfValue(value.match, value.flags);
        }
    }
}}}}