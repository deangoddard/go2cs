//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class bzip2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bitReader
        {
            // Constructors
            public bitReader(NilType _)
            {
                this.r = default;
                this.n = default;
                this.bits = default;
                this.err = default;
            }

            public bitReader(io.ByteReader r = default, ulong n = default, ulong bits = default, error err = default)
            {
                this.r = r;
                this.n = n;
                this.bits = bits;
                this.err = err;
            }

            // Enable comparisons between nil and bitReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitReader value, NilType nil) => value.Equals(default(bitReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitReader(NilType nil) => default(bitReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bitReader bitReader_cast(dynamic value)
        {
            return new bitReader(value.r, value.n, value.bits, value.err);
        }
    }
}}