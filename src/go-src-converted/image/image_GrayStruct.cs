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
        public partial struct Gray
        {
            // Constructors
            public Gray(NilType _)
            {
                this.Pix = default;
                this.Stride = default;
                this.Rect = default;
            }

            public Gray(slice<byte> Pix = default, long Stride = default, Rectangle Rect = default)
            {
                this.Pix = Pix;
                this.Stride = Stride;
                this.Rect = Rect;
            }

            // Enable comparisons between nil and Gray struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Gray value, NilType nil) => value.Equals(default(Gray));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Gray value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Gray value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Gray value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Gray(NilType nil) => default(Gray);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Gray Gray_cast(dynamic value)
        {
            return new Gray(value.Pix, value.Stride, value.Rect);
        }
    }
}