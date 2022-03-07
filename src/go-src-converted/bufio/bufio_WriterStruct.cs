//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:14:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class bufio_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Writer
        {
            // Constructors
            public Writer(NilType _)
            {
                this.err = default;
                this.buf = default;
                this.n = default;
                this.wr = default;
            }

            public Writer(error err = default, slice<byte> buf = default, nint n = default, io.Writer wr = default)
            {
                this.err = err;
                this.buf = buf;
                this.n = n;
                this.wr = wr;
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(value.err, value.buf, value.n, value.wr);
        }
    }
}