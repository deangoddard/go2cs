//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using color = go.image.color_package;

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Paletted
        {
            // Constructors
            public Paletted(NilType _)
            {
                this.Pix = default;
                this.Stride = default;
                this.Rect = default;
                this.Palette = default;
            }

            public Paletted(slice<byte> Pix = default, long Stride = default, Rectangle Rect = default, color.Palette Palette = default)
            {
                this.Pix = Pix;
                this.Stride = Stride;
                this.Rect = Rect;
                this.Palette = Palette;
            }

            // Enable comparisons between nil and Paletted struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Paletted value, NilType nil) => value.Equals(default(Paletted));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Paletted value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Paletted value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Paletted value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Paletted(NilType nil) => default(Paletted);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Paletted Paletted_cast(dynamic value)
        {
            return new Paletted(value.Pix, value.Stride, value.Rect, value.Palette);
        }
    }
}