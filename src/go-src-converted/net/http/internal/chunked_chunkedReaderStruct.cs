//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace net {
namespace http
{
    public static partial class @internal_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct chunkedReader
        {
            // Constructors
            public chunkedReader(NilType _)
            {
                this.r = default;
                this.n = default;
                this.err = default;
                this.buf = default;
                this.checkEnd = default;
            }

            public chunkedReader(ref ptr<bufio.Reader> r = default, ulong n = default, error err = default, array<byte> buf = default, bool checkEnd = default)
            {
                this.r = r;
                this.n = n;
                this.err = err;
                this.buf = buf;
                this.checkEnd = checkEnd;
            }

            // Enable comparisons between nil and chunkedReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chunkedReader value, NilType nil) => value.Equals(default(chunkedReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chunkedReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chunkedReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chunkedReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chunkedReader(NilType nil) => default(chunkedReader);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static chunkedReader chunkedReader_cast(dynamic value)
        {
            return new chunkedReader(ref value.r, value.n, value.err, value.buf, value.checkEnd);
        }
    }
}}}