//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using zlib = go.compress.zlib_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct loadCmdReader
        {
            // Constructors
            public loadCmdReader(NilType _)
            {
                this.offset = default;
                this.next = default;
                this.f = default;
                this.order = default;
            }

            public loadCmdReader(long offset = default, long next = default, ref ptr<os.File> f = default, binary.ByteOrder order = default)
            {
                this.offset = offset;
                this.next = next;
                this.f = f;
                this.order = order;
            }

            // Enable comparisons between nil and loadCmdReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loadCmdReader value, NilType nil) => value.Equals(default(loadCmdReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loadCmdReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loadCmdReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loadCmdReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loadCmdReader(NilType nil) => default(loadCmdReader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static loadCmdReader loadCmdReader_cast(dynamic value)
        {
            return new loadCmdReader(value.offset, value.next, ref value.f, value.order);
        }
    }
}}}}