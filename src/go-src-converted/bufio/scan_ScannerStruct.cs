//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;

namespace go
{
    public static partial class bufio_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Scanner
        {
            // Constructors
            public Scanner(NilType _)
            {
                this.r = default;
                this.split = default;
                this.maxTokenSize = default;
                this.token = default;
                this.buf = default;
                this.start = default;
                this.end = default;
                this.err = default;
                this.empties = default;
                this.scanCalled = default;
                this.done = default;
            }

            public Scanner(io.Reader r = default, SplitFunc split = default, long maxTokenSize = default, slice<byte> token = default, slice<byte> buf = default, long start = default, long end = default, error err = default, long empties = default, bool scanCalled = default, bool done = default)
            {
                this.r = r;
                this.split = split;
                this.maxTokenSize = maxTokenSize;
                this.token = token;
                this.buf = buf;
                this.start = start;
                this.end = end;
                this.err = err;
                this.empties = empties;
                this.scanCalled = scanCalled;
                this.done = done;
            }

            // Enable comparisons between nil and Scanner struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Scanner value, NilType nil) => value.Equals(default(Scanner));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Scanner value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Scanner value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Scanner value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Scanner(NilType nil) => default(Scanner);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Scanner Scanner_cast(dynamic value)
        {
            return new Scanner(value.r, value.split, value.maxTokenSize, value.token, value.buf, value.start, value.end, value.err, value.empties, value.scanCalled, value.done);
        }
    }
}