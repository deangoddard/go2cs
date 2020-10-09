//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using color = go.image.color_package;

#nullable enable

namespace go
{
    public static partial class image_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Alpha
        {
            // Constructors
            public Alpha(NilType _)
            {
                this.Pix = default;
                this.Stride = default;
                this.Rect = default;
            }

            public Alpha(slice<byte> Pix = default, long Stride = default, Rectangle Rect = default)
            {
                this.Pix = Pix;
                this.Stride = Stride;
                this.Rect = Rect;
            }

            // Enable comparisons between nil and Alpha struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Alpha value, NilType nil) => value.Equals(default(Alpha));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Alpha value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Alpha value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Alpha value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Alpha(NilType nil) => default(Alpha);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Alpha Alpha_cast(dynamic value)
        {
            return new Alpha(value.Pix, value.Stride, value.Rect);
        }
    }
}