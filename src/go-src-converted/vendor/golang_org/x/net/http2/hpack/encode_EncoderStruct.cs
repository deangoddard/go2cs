//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:39 UTC
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
namespace vendor {
namespace golang_org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Encoder
        {
            // Constructors
            public Encoder(NilType _)
            {
                this.dynTab = default;
                this.minSize = default;
                this.maxSizeLimit = default;
                this.tableSizeUpdate = default;
                this.w = default;
                this.buf = default;
            }

            public Encoder(dynamicTable dynTab = default, uint minSize = default, uint maxSizeLimit = default, bool tableSizeUpdate = default, io.Writer w = default, slice<byte> buf = default)
            {
                this.dynTab = dynTab;
                this.minSize = minSize;
                this.maxSizeLimit = maxSizeLimit;
                this.tableSizeUpdate = tableSizeUpdate;
                this.w = w;
                this.buf = buf;
            }

            // Enable comparisons between nil and Encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Encoder value, NilType nil) => value.Equals(default(Encoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Encoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Encoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Encoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Encoder(NilType nil) => default(Encoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Encoder Encoder_cast(dynamic value)
        {
            return new Encoder(value.dynTab, value.minSize, value.maxSizeLimit, value.tableSizeUpdate, value.w, value.buf);
        }
    }
}}}}}}