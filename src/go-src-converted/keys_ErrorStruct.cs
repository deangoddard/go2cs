//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using strconv = go.strconv_package;
using label = go.golang.org.x.tools.@internal.@event.label_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class keys_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Error
        {
            // Constructors
            public Error(NilType _)
            {
                this.name = default;
                this.description = default;
            }

            public Error(@string name = default, @string description = default)
            {
                this.name = name;
                this.description = description;
            }

            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Error Error_cast(dynamic value)
        {
            return new Error(value.name, value.description);
        }
    }
}}}}}}