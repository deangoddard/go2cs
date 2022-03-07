//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using io = go.io_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class bzip2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct reader
        {
            // Constructors
            public reader(NilType _)
            {
                this.br = default;
                this.fileCRC = default;
                this.blockCRC = default;
                this.wantBlockCRC = default;
                this.setupDone = default;
                this.blockSize = default;
                this.eof = default;
                this.c = default;
                this.tt = default;
                this.tPos = default;
                this.preRLE = default;
                this.preRLEUsed = default;
                this.lastByte = default;
                this.byteRepeats = default;
                this.repeats = default;
            }

            public reader(bitReader br = default, uint fileCRC = default, uint blockCRC = default, uint wantBlockCRC = default, bool setupDone = default, nint blockSize = default, bool eof = default, array<nuint> c = default, slice<uint> tt = default, uint tPos = default, slice<uint> preRLE = default, nint preRLEUsed = default, nint lastByte = default, nuint byteRepeats = default, nuint repeats = default)
            {
                this.br = br;
                this.fileCRC = fileCRC;
                this.blockCRC = blockCRC;
                this.wantBlockCRC = wantBlockCRC;
                this.setupDone = setupDone;
                this.blockSize = blockSize;
                this.eof = eof;
                this.c = c;
                this.tt = tt;
                this.tPos = tPos;
                this.preRLE = preRLE;
                this.preRLEUsed = preRLEUsed;
                this.lastByte = lastByte;
                this.byteRepeats = byteRepeats;
                this.repeats = repeats;
            }

            // Enable comparisons between nil and reader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(reader value, NilType nil) => value.Equals(default(reader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(reader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, reader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, reader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator reader(NilType nil) => default(reader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static reader reader_cast(dynamic value)
        {
            return new reader(value.br, value.fileCRC, value.blockCRC, value.wantBlockCRC, value.setupDone, value.blockSize, value.eof, value.c, value.tt, value.tPos, value.preRLE, value.preRLEUsed, value.lastByte, value.byteRepeats, value.repeats);
        }
    }
}}