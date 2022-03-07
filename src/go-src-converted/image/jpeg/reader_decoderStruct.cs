//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:36:10 UTC
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct decoder
        {
            // Constructors
            public decoder(NilType _)
            {
                this.r = default;
                this.bits = default;
                this.width = default;
                this.height = default;
                this.img1 = default;
                this.img3 = default;
                this.blackPix = default;
                this.blackStride = default;
                this.ri = default;
                this.nComp = default;
                this.baseline = default;
                this.progressive = default;
                this.jfif = default;
                this.adobeTransformValid = default;
                this.adobeTransform = default;
                this.eobRun = default;
                this.comp = default;
                this.progCoeffs = default;
                this.huff = default;
                this.quant = default;
                this.tmp = default;
            }

            public decoder(io.Reader r = default, bits bits = default, nint width = default, nint height = default, ref ptr<image.Gray> img1 = default, ref ptr<image.YCbCr> img3 = default, slice<byte> blackPix = default, nint blackStride = default, nint ri = default, nint nComp = default, bool baseline = default, bool progressive = default, bool jfif = default, bool adobeTransformValid = default, byte adobeTransform = default, ushort eobRun = default, array<component> comp = default, array<slice<block>> progCoeffs = default, array<array<huffman>> huff = default, array<block> quant = default, array<byte> tmp = default)
            {
                this.r = r;
                this.bits = bits;
                this.width = width;
                this.height = height;
                this.img1 = img1;
                this.img3 = img3;
                this.blackPix = blackPix;
                this.blackStride = blackStride;
                this.ri = ri;
                this.nComp = nComp;
                this.baseline = baseline;
                this.progressive = progressive;
                this.jfif = jfif;
                this.adobeTransformValid = adobeTransformValid;
                this.adobeTransform = adobeTransform;
                this.eobRun = eobRun;
                this.comp = comp;
                this.progCoeffs = progCoeffs;
                this.huff = huff;
                this.quant = quant;
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
            return new decoder(value.r, value.bits, value.width, value.height, ref value.img1, ref value.img3, value.blackPix, value.blackStride, value.ri, value.nComp, value.baseline, value.progressive, value.jfif, value.adobeTransformValid, value.adobeTransform, value.eobRun, value.comp, value.progCoeffs, value.huff, value.quant, value.tmp);
        }
    }
}}