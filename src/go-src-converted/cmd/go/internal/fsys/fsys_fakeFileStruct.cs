//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using fs = go.io.fs_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class fsys_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct fakeFile
        {
            // Constructors
            public fakeFile(NilType _)
            {
                this.name = default;
                this.real = default;
            }

            public fakeFile(@string name = default, fs.FileInfo real = default)
            {
                this.name = name;
                this.real = real;
            }

            // Enable comparisons between nil and fakeFile struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fakeFile value, NilType nil) => value.Equals(default(fakeFile));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fakeFile value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fakeFile value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fakeFile value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fakeFile(NilType nil) => default(fakeFile);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static fakeFile fakeFile_cast(dynamic value)
        {
            return new fakeFile(value.name, value.real);
        }
    }
}}}}