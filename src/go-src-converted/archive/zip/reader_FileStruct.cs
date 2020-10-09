//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using hash = go.hash_package;
using crc32 = go.hash.crc32_package;
using io = go.io_package;
using os = go.os_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct File
        {
            // Constructors
            public File(NilType _)
            {
                this.FileHeader = default;
                this.zip = default;
                this.zipr = default;
                this.zipsize = default;
                this.headerOffset = default;
            }

            public File(FileHeader FileHeader = default, ref ptr<Reader> zip = default, io.ReaderAt zipr = default, long zipsize = default, long headerOffset = default)
            {
                this.FileHeader = FileHeader;
                this.zip = zip;
                this.zipr = zipr;
                this.zipsize = zipsize;
                this.headerOffset = headerOffset;
            }

            // Enable comparisons between nil and File struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(File value, NilType nil) => value.Equals(default(File));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(File value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, File value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, File value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator File(NilType nil) => default(File);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static File File_cast(dynamic value)
        {
            return new File(value.FileHeader, ref value.zip, value.zipr, value.zipsize, value.headerOffset);
        }
    }
}}