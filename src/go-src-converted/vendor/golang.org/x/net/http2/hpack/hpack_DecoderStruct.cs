//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:45:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace http2
{
    public static partial class hpack_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Decoder
        {
            // Constructors
            public Decoder(NilType _)
            {
                this.dynTab = default;
                this.emit = default;
                this.emitEnabled = default;
                this.maxStrLen = default;
                this.buf = default;
                this.saveBuf = default;
                this.firstField = default;
            }

            public Decoder(dynamicTable dynTab = default, Action<HeaderField> emit = default, bool emitEnabled = default, nint maxStrLen = default, slice<byte> buf = default, bytes.Buffer saveBuf = default, bool firstField = default)
            {
                this.dynTab = dynTab;
                this.emit = emit;
                this.emitEnabled = emitEnabled;
                this.maxStrLen = maxStrLen;
                this.buf = buf;
                this.saveBuf = saveBuf;
                this.firstField = firstField;
            }

            // Enable comparisons between nil and Decoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Decoder value, NilType nil) => value.Equals(default(Decoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Decoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Decoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Decoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Decoder(NilType nil) => default(Decoder);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Decoder Decoder_cast(dynamic value)
        {
            return new Decoder(value.dynTab, value.emit, value.emitEnabled, value.maxStrLen, value.buf, value.saveBuf, value.firstField);
        }
    }
}}}}}}