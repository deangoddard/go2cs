//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:28:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class @base_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct @event
        {
            // Constructors
            public @event(NilType _)
            {
                this.size = default;
                this.unit = default;
            }

            public @event(long size = default, @string unit = default)
            {
                this.size = size;
                this.unit = unit;
            }

            // Enable comparisons between nil and @event struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(@event value, NilType nil) => value.Equals(default(@event));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(@event value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, @event value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, @event value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @event(NilType nil) => default(@event);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static @event @event_cast(dynamic value)
        {
            return new @event(value.size, value.unit);
        }
    }
}}}}