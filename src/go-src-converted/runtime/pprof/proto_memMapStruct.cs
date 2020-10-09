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
        private partial struct memMap
        {
            // Constructors
            public memMap(NilType _)
            {
                this.start = default;
                this.end = default;
                this.offset = default;
                this.file = default;
                this.buildID = default;
                this.funcs = default;
                this.fake = default;
            }

            public memMap(System.UIntPtr start = default, System.UIntPtr end = default, ulong offset = default, @string file = default, @string buildID = default, symbolizeFlag funcs = default, bool fake = default)
            {
                this.start = start;
                this.end = end;
                this.offset = offset;
                this.file = file;
                this.buildID = buildID;
                this.funcs = funcs;
                this.fake = fake;
            }

            // Enable comparisons between nil and memMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(memMap value, NilType nil) => value.Equals(default(memMap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(memMap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, memMap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, memMap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator memMap(NilType nil) => default(memMap);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static memMap memMap_cast(dynamic value)
        {
            return new memMap(value.start, value.end, value.offset, value.file, value.buildID, value.funcs, value.fake);
        }
    }
}}