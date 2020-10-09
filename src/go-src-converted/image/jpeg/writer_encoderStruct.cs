//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using image = go.image_package;
using color = go.image.color_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encoder
        {
            // Constructors
            public encoder(NilType _)
            {
                this.w = default;
                this.err = default;
                this.buf = default;
                this.bits = default;
                this.nBits = default;
                this.quant = default;
            }

            public encoder(writer w = default, error err = default, array<byte> buf = default, uint bits = default, uint nBits = default, array<array<byte>> quant = default)
            {
                this.w = w;
                this.err = err;
                this.buf = buf;
                this.bits = bits;
                this.nBits = nBits;
                this.quant = quant;
            }

            // Enable comparisons between nil and encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encoder value, NilType nil) => value.Equals(default(encoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoder(NilType nil) => default(encoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static encoder encoder_cast(dynamic value)
        {
            return new encoder(value.w, value.err, value.buf, value.bits, value.nBits, value.quant);
        }
    }
}}