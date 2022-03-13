//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using io = go.io_package;
using math = go.math_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(compressionLevel))]
        private partial struct compressor
        {
            // compressionLevel structure promotion - sourced from value copy
            private readonly ptr<compressionLevel> m_compressionLevelRef;

            private ref compressionLevel compressionLevel_val => ref m_compressionLevelRef.Value;

            public ref nint level => ref m_compressionLevelRef.Value.level;

            public ref nint good => ref m_compressionLevelRef.Value.good;

            public ref nint lazy => ref m_compressionLevelRef.Value.lazy;

            public ref nint nice => ref m_compressionLevelRef.Value.nice;

            public ref nint chain => ref m_compressionLevelRef.Value.chain;

            public ref nint fastSkipHashing => ref m_compressionLevelRef.Value.fastSkipHashing;

            // Constructors
            public compressor(NilType _)
            {
                this.m_compressionLevelRef = new ptr<compressionLevel>(new compressionLevel(nil));
                this.w = default;
                this.bulkHasher = default;
                this.fill = default;
                this.step = default;
                this.sync = default;
                this.bestSpeed = default;
                this.chainHead = default;
                this.hashHead = default;
                this.hashPrev = default;
                this.hashOffset = default;
                this.index = default;
                this.window = default;
                this.windowEnd = default;
                this.blockStart = default;
                this.byteAvailable = default;
                this.tokens = default;
                this.length = default;
                this.offset = default;
                this.hash = default;
                this.maxInsertIndex = default;
                this.err = default;
                this.hashMatch = default;
            }

            public compressor(compressionLevel compressionLevel = default, ref ptr<huffmanBitWriter> w = default, Action<slice<byte>, slice<uint>> bulkHasher = default, Func<ptr<compressor>, slice<byte>, nint> fill = default, Action<ptr<compressor>> step = default, bool sync = default, ref ptr<deflateFast> bestSpeed = default, nint chainHead = default, array<uint> hashHead = default, array<uint> hashPrev = default, nint hashOffset = default, nint index = default, slice<byte> window = default, nint windowEnd = default, nint blockStart = default, bool byteAvailable = default, slice<token> tokens = default, nint length = default, nint offset = default, uint hash = default, nint maxInsertIndex = default, error err = default, array<uint> hashMatch = default)
            {
                this.m_compressionLevelRef = new ptr<compressionLevel>(compressionLevel);
                this.w = w;
                this.bulkHasher = bulkHasher;
                this.fill = fill;
                this.step = step;
                this.sync = sync;
                this.bestSpeed = bestSpeed;
                this.chainHead = chainHead;
                this.hashHead = hashHead;
                this.hashPrev = hashPrev;
                this.hashOffset = hashOffset;
                this.index = index;
                this.window = window;
                this.windowEnd = windowEnd;
                this.blockStart = blockStart;
                this.byteAvailable = byteAvailable;
                this.tokens = tokens;
                this.length = length;
                this.offset = offset;
                this.hash = hash;
                this.maxInsertIndex = maxInsertIndex;
                this.err = err;
                this.hashMatch = hashMatch;
            }

            // Enable comparisons between nil and compressor struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(compressor value, NilType nil) => value.Equals(default(compressor));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(compressor value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, compressor value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, compressor value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator compressor(NilType nil) => default(compressor);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static compressor compressor_cast(dynamic value)
        {
            return new compressor(value.compressionLevel, ref value.w, value.bulkHasher, value.fill, value.step, value.sync, ref value.bestSpeed, value.chainHead, value.hashHead, value.hashPrev, value.hashOffset, value.index, value.window, value.windowEnd, value.blockStart, value.byteAvailable, value.tokens, value.length, value.offset, value.hash, value.maxInsertIndex, value.err, value.hashMatch);
        }
    }
}}