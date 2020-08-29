//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using go;

namespace go {
namespace image
{
    public static partial class jpeg_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct huffman
        {
            // Constructors
            public huffman(NilType _)
            {
                this.nCodes = default;
                this.lut = default;
                this.vals = default;
                this.minCodes = default;
                this.maxCodes = default;
                this.valsIndices = default;
            }

            public huffman(int nCodes = default, array<ushort> lut = default, array<byte> vals = default, array<int> minCodes = default, array<int> maxCodes = default, array<int> valsIndices = default)
            {
                this.nCodes = nCodes;
                this.lut = lut;
                this.vals = vals;
                this.minCodes = minCodes;
                this.maxCodes = maxCodes;
                this.valsIndices = valsIndices;
            }

            // Enable comparisons between nil and huffman struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(huffman value, NilType nil) => value.Equals(default(huffman));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(huffman value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, huffman value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, huffman value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator huffman(NilType nil) => default(huffman);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static huffman huffman_cast(dynamic value)
        {
            return new huffman(value.nCodes, value.lut, value.vals, value.minCodes, value.maxCodes, value.valsIndices);
        }
    }
}}