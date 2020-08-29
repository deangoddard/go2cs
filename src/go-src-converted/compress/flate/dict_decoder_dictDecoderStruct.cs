//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:23:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dictDecoder
        {
            // Constructors
            public dictDecoder(NilType _)
            {
                this.hist = default;
                this.wrPos = default;
                this.rdPos = default;
                this.full = default;
            }

            public dictDecoder(slice<byte> hist = default, long wrPos = default, long rdPos = default, bool full = default)
            {
                this.hist = hist;
                this.wrPos = wrPos;
                this.rdPos = rdPos;
                this.full = full;
            }

            // Enable comparisons between nil and dictDecoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dictDecoder value, NilType nil) => value.Equals(default(dictDecoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dictDecoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dictDecoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dictDecoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dictDecoder(NilType nil) => default(dictDecoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dictDecoder dictDecoder_cast(dynamic value)
        {
            return new dictDecoder(value.hist, value.wrPos, value.rdPos, value.full);
        }
    }
}}