//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:44:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using image = go.image_package;
using color = go.image.color_package;
using imageutil = go.image.@internal.imageutil_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct component
        {
            // Constructors
            public component(NilType _)
            {
                this.h = default;
                this.v = default;
                this.c = default;
                this.tq = default;
            }

            public component(nint h = default, nint v = default, byte c = default, byte tq = default)
            {
                this.h = h;
                this.v = v;
                this.c = c;
                this.tq = tq;
            }

            // Enable comparisons between nil and component struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(component value, NilType nil) => value.Equals(default(component));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(component value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, component value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, component value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator component(NilType nil) => default(component);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static component component_cast(dynamic value)
        {
            return new component(value.h, value.v, value.c, value.tq);
        }
    }
}}