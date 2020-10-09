//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using runtime = go.runtime_package;
using strconv = go.strconv_package;
using time = go.time_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct profileBuilder
        {
            // Constructors
            public profileBuilder(NilType _)
            {
                this.start = default;
                this.end = default;
                this.havePeriod = default;
                this.period = default;
                this.m = default;
                this.w = default;
                this.zw = default;
                this.pb = default;
                this.strings = default;
                this.stringMap = default;
                this.locs = default;
                this.funcs = default;
                this.mem = default;
                this.deck = default;
            }

            public profileBuilder(time.Time start = default, time.Time end = default, bool havePeriod = default, long period = default, profMap m = default, io.Writer w = default, ref ptr<gzip.Writer> zw = default, protobuf pb = default, slice<@string> strings = default, map<@string, long> stringMap = default, map<System.UIntPtr, locInfo> locs = default, map<@string, long> funcs = default, slice<memMap> mem = default, pcDeck deck = default)
            {
                this.start = start;
                this.end = end;
                this.havePeriod = havePeriod;
                this.period = period;
                this.m = m;
                this.w = w;
                this.zw = zw;
                this.pb = pb;
                this.strings = strings;
                this.stringMap = stringMap;
                this.locs = locs;
                this.funcs = funcs;
                this.mem = mem;
                this.deck = deck;
            }

            // Enable comparisons between nil and profileBuilder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(profileBuilder value, NilType nil) => value.Equals(default(profileBuilder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(profileBuilder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, profileBuilder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, profileBuilder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator profileBuilder(NilType nil) => default(profileBuilder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static profileBuilder profileBuilder_cast(dynamic value)
        {
            return new profileBuilder(value.start, value.end, value.havePeriod, value.period, value.m, value.w, ref value.zw, value.pb, value.strings, value.stringMap, value.locs, value.funcs, value.mem, value.deck);
        }
    }
}}