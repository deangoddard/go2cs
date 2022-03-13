//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct huffmanBitWriter
        {
            // Constructors
            public huffmanBitWriter(NilType _)
            {
                this.writer = default;
                this.bits = default;
                this.nbits = default;
                this.bytes = default;
                this.codegenFreq = default;
                this.nbytes = default;
                this.literalFreq = default;
                this.offsetFreq = default;
                this.codegen = default;
                this.literalEncoding = default;
                this.offsetEncoding = default;
                this.codegenEncoding = default;
                this.err = default;
            }

            public huffmanBitWriter(io.Writer writer = default, ulong bits = default, nuint nbits = default, array<byte> bytes = default, array<int> codegenFreq = default, nint nbytes = default, slice<int> literalFreq = default, slice<int> offsetFreq = default, slice<byte> codegen = default, ref ptr<huffmanEncoder> literalEncoding = default, ref ptr<huffmanEncoder> offsetEncoding = default, ref ptr<huffmanEncoder> codegenEncoding = default, error err = default)
            {
                this.writer = writer;
                this.bits = bits;
                this.nbits = nbits;
                this.bytes = bytes;
                this.codegenFreq = codegenFreq;
                this.nbytes = nbytes;
                this.literalFreq = literalFreq;
                this.offsetFreq = offsetFreq;
                this.codegen = codegen;
                this.literalEncoding = literalEncoding;
                this.offsetEncoding = offsetEncoding;
                this.codegenEncoding = codegenEncoding;
                this.err = err;
            }

            // Enable comparisons between nil and huffmanBitWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(huffmanBitWriter value, NilType nil) => value.Equals(default(huffmanBitWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(huffmanBitWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, huffmanBitWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, huffmanBitWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator huffmanBitWriter(NilType nil) => default(huffmanBitWriter);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static huffmanBitWriter huffmanBitWriter_cast(dynamic value)
        {
            return new huffmanBitWriter(value.writer, value.bits, value.nbits, value.bytes, value.codegenFreq, value.nbytes, value.literalFreq, value.offsetFreq, value.codegen, ref value.literalEncoding, ref value.offsetEncoding, ref value.codegenEncoding, value.err);
        }
    }
}}