//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:37 UTC
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
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text
{
    public static partial class transform_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Reader
        {
            // Constructors
            public Reader(NilType _)
            {
                this.r = default;
                this.t = default;
                this.err = default;
                this.dst = default;
                this.dst0 = default;
                this.dst1 = default;
                this.src = default;
                this.src0 = default;
                this.src1 = default;
                this.transformComplete = default;
            }

            public Reader(io.Reader r = default, Transformer t = default, error err = default, slice<byte> dst = default, nint dst0 = default, nint dst1 = default, slice<byte> src = default, nint src0 = default, nint src1 = default, bool transformComplete = default)
            {
                this.r = r;
                this.t = t;
                this.err = err;
                this.dst = dst;
                this.dst0 = dst0;
                this.dst1 = dst1;
                this.src = src;
                this.src0 = src0;
                this.src1 = src1;
                this.transformComplete = transformComplete;
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
            return new Reader(value.r, value.t, value.err, value.dst, value.dst0, value.dst1, value.src, value.src0, value.src1, value.transformComplete);
        }
    }
}}}}}