//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct UInt16
        {
            // Constructors
            public UInt16(NilType _)
            {
                this.name = default;
                this.description = default;
            }

            public UInt16(@string name = default, @string description = default)
            {
                this.name = name;
                this.description = description;
            }

            // Enable comparisons between nil and UInt16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UInt16 value, NilType nil) => value.Equals(default(UInt16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UInt16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UInt16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UInt16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UInt16(NilType nil) => default(UInt16);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static UInt16 UInt16_cast(dynamic value)
        {
            return new UInt16(value.name, value.description);
        }
    }
}}}}}}