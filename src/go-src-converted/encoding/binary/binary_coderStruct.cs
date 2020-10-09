//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class binary_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct coder
        {
            // Constructors
            public coder(NilType _)
            {
                this.order = default;
                this.buf = default;
                this.offset = default;
            }

            public coder(ByteOrder order = default, slice<byte> buf = default, long offset = default)
            {
                this.order = order;
                this.buf = buf;
                this.offset = offset;
            }

            // Enable comparisons between nil and coder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(coder value, NilType nil) => value.Equals(default(coder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(coder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, coder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, coder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator coder(NilType nil) => default(coder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static coder coder_cast(dynamic value)
        {
            return new coder(value.order, value.buf, value.offset);
        }
    }
}}