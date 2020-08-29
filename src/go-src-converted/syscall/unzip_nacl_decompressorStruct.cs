//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:38:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct decompressor
        {
            // Constructors
            public decompressor(NilType _)
            {
                this.@in = default;
                this.@out = default;
                this.b = default;
                this.nb = default;
                this.err = default;
                this.eof = default;
                this.h1 = default;
                this.h2 = default;
                this.bits = default;
                this.codebits = default;
            }

            public decompressor(@string @in = default, slice<byte> @out = default, uint b = default, ulong nb = default, bool err = default, bool eof = default, huffmanDecoder h1 = default, huffmanDecoder h2 = default, array<long> bits = default, array<long> codebits = default)
            {
                this.@in = @in;
                this.@out = @out;
                this.b = b;
                this.nb = nb;
                this.err = err;
                this.eof = eof;
                this.h1 = h1;
                this.h2 = h2;
                this.bits = bits;
                this.codebits = codebits;
            }

            // Enable comparisons between nil and decompressor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(decompressor value, NilType nil) => value.Equals(default(decompressor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(decompressor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, decompressor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, decompressor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator decompressor(NilType nil) => default(decompressor);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static decompressor decompressor_cast(dynamic value)
        {
            return new decompressor(value.@in, value.@out, value.b, value.nb, value.err, value.eof, value.h1, value.h2, value.bits, value.codebits);
        }
    }
}