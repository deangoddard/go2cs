//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using hash = go.hash_package;
using crc32 = go.hash.crc32_package;
using io = go.io_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct countWriter
        {
            // Constructors
            public countWriter(NilType _)
            {
                this.w = default;
                this.count = default;
            }

            public countWriter(io.Writer w = default, long count = default)
            {
                this.w = w;
                this.count = count;
            }

            // Enable comparisons between nil and countWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(countWriter value, NilType nil) => value.Equals(default(countWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(countWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, countWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, countWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator countWriter(NilType nil) => default(countWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static countWriter countWriter_cast(dynamic value)
        {
            return new countWriter(value.w, value.count);
        }
    }
}}