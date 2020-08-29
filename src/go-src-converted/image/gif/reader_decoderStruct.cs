//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using lzw = go.compress.lzw_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using image = go.image_package;
using color = go.image.color_package;
using io = go.io_package;
using go;

namespace go {
namespace image
{
    public static partial class gif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct decoder
        {
            // Constructors
            public decoder(NilType _)
            {
                this.r = default;
                this.vers = default;
                this.width = default;
                this.height = default;
                this.loopCount = default;
                this.delayTime = default;
                this.backgroundIndex = default;
                this.disposalMethod = default;
                this.imageFields = default;
                this.transparentIndex = default;
                this.hasTransparentIndex = default;
                this.globalColorTable = default;
                this.delay = default;
                this.disposal = default;
                this.image = default;
                this.tmp = default;
            }

            public decoder(reader r = default, @string vers = default, long width = default, long height = default, long loopCount = default, long delayTime = default, byte backgroundIndex = default, byte disposalMethod = default, byte imageFields = default, byte transparentIndex = default, bool hasTransparentIndex = default, color.Palette globalColorTable = default, slice<long> delay = default, slice<byte> disposal = default, slice<ref image.Paletted> image = default, array<byte> tmp = default)
            {
                this.r = r;
                this.vers = vers;
                this.width = width;
                this.height = height;
                this.loopCount = loopCount;
                this.delayTime = delayTime;
                this.backgroundIndex = backgroundIndex;
                this.disposalMethod = disposalMethod;
                this.imageFields = imageFields;
                this.transparentIndex = transparentIndex;
                this.hasTransparentIndex = hasTransparentIndex;
                this.globalColorTable = globalColorTable;
                this.delay = delay;
                this.disposal = disposal;
                this.image = image;
                this.tmp = tmp;
            }

            // Enable comparisons between nil and decoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(decoder value, NilType nil) => value.Equals(default(decoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(decoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, decoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, decoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator decoder(NilType nil) => default(decoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static decoder decoder_cast(dynamic value)
        {
            return new decoder(value.r, value.vers, value.width, value.height, value.loopCount, value.delayTime, value.backgroundIndex, value.disposalMethod, value.imageFields, value.transparentIndex, value.hasTransparentIndex, value.globalColorTable, value.delay, value.disposal, value.image, value.tmp);
        }
    }
}}