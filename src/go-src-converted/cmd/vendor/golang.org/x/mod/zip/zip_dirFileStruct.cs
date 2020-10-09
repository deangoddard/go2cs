//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:56:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class zip_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dirFile
        {
            // Constructors
            public dirFile(NilType _)
            {
                this.filePath = default;
                this.slashPath = default;
                this.info = default;
            }

            public dirFile(@string filePath = default, @string slashPath = default, os.FileInfo info = default)
            {
                this.filePath = filePath;
                this.slashPath = slashPath;
                this.info = info;
            }

            // Enable comparisons between nil and dirFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dirFile value, NilType nil) => value.Equals(default(dirFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dirFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dirFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dirFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dirFile(NilType nil) => default(dirFile);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dirFile dirFile_cast(dynamic value)
        {
            return new dirFile(value.filePath, value.slashPath, value.info);
        }
    }
}}}}}}