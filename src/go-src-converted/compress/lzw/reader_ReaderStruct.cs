//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:43:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class lzw_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Reader
        {
            // Constructors
            public Reader(NilType _)
            {
                this.r = default;
                this.bits = default;
                this.nBits = default;
                this.width = default;
                this.read = default;
                this.litWidth = default;
                this.err = default;
                this.clear = default;
                this.eof = default;
                this.hi = default;
                this.overflow = default;
                this.last = default;
                this.suffix = default;
                this.prefix = default;
                this.output = default;
                this.o = default;
                this.toRead = default;
            }

            public Reader(io.ByteReader r = default, uint bits = default, nuint nBits = default, nuint width = default, Func<ptr<Reader>, (ushort, error)> read = default, nint litWidth = default, error err = default, ushort clear = default, ushort eof = default, ushort hi = default, ushort overflow = default, ushort last = default, array<byte> suffix = default, array<ushort> prefix = default, array<byte> output = default, nint o = default, slice<byte> toRead = default)
            {
                this.r = r;
                this.bits = bits;
                this.nBits = nBits;
                this.width = width;
                this.read = read;
                this.litWidth = litWidth;
                this.err = err;
                this.clear = clear;
                this.eof = eof;
                this.hi = hi;
                this.overflow = overflow;
                this.last = last;
                this.suffix = suffix;
                this.prefix = prefix;
                this.output = output;
                this.o = o;
                this.toRead = toRead;
            }

            // Enable comparisons between nil and Reader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reader value, NilType nil) => value.Equals(default(Reader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reader(NilType nil) => default(Reader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Reader Reader_cast(dynamic value)
        {
            return new Reader(value.r, value.bits, value.nBits, value.width, value.read, value.litWidth, value.err, value.clear, value.eof, value.hi, value.overflow, value.last, value.suffix, value.prefix, value.output, value.o, value.toRead);
        }
    }
}}