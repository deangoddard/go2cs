//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:52 UTC
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
        public partial struct YCbCr
        {
            // Constructors
            public YCbCr(NilType _)
            {
                this.Y = default;
                this.Cb = default;
                this.Cr = default;
                this.YStride = default;
                this.CStride = default;
                this.SubsampleRatio = default;
                this.Rect = default;
            }

            public YCbCr(slice<byte> Y = default, slice<byte> Cb = default, slice<byte> Cr = default, long YStride = default, long CStride = default, YCbCrSubsampleRatio SubsampleRatio = default, Rectangle Rect = default)
            {
                this.Y = Y;
                this.Cb = Cb;
                this.Cr = Cr;
                this.YStride = YStride;
                this.CStride = CStride;
                this.SubsampleRatio = SubsampleRatio;
                this.Rect = Rect;
            }

            // Enable comparisons between nil and YCbCr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(YCbCr value, NilType nil) => value.Equals(default(YCbCr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(YCbCr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, YCbCr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, YCbCr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator YCbCr(NilType nil) => default(YCbCr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static YCbCr YCbCr_cast(dynamic value)
        {
            return new YCbCr(value.Y, value.Cb, value.Cr, value.YStride, value.CStride, value.SubsampleRatio, value.Rect);
        }
    }
}