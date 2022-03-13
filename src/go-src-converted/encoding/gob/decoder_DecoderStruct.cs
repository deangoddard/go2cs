//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:39:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using errors = go.errors_package;
using io = go.io_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Decoder
        {
            // Constructors
            public Decoder(NilType _)
            {
                this.mutex = default;
                this.r = default;
                this.buf = default;
                this.wireType = default;
                this.decoderCache = default;
                this.ignorerCache = default;
                this.freeList = default;
                this.countBuf = default;
                this.err = default;
            }

            public Decoder(sync.Mutex mutex = default, io.Reader r = default, decBuffer buf = default, map<typeId, ptr<wireType>> wireType = default, map<reflect.Type, map<typeId, ptr<ptr<decEngine>>>> decoderCache = default, map<typeId, ptr<ptr<decEngine>>> ignorerCache = default, ref ptr<decoderState> freeList = default, slice<byte> countBuf = default, error err = default)
            {
                this.mutex = mutex;
                this.r = r;
                this.buf = buf;
                this.wireType = wireType;
                this.decoderCache = decoderCache;
                this.ignorerCache = ignorerCache;
                this.freeList = freeList;
                this.countBuf = countBuf;
                this.err = err;
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
            return new Decoder(value.mutex, value.r, value.buf, value.wireType, value.decoderCache, value.ignorerCache, ref value.freeList, value.countBuf, value.err);
        }
    }
}}