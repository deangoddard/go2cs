//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:43:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using fs = go.io.fs_package;
using path = go.path_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strings = go.strings_package;
using iotest = go.testing.iotest_package;
using go;

#nullable enable

namespace go {
namespace testing
{
    public static partial class fstest_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct fsTester
        {
            // Constructors
            public fsTester(NilType _)
            {
                this.fsys = default;
                this.errText = default;
                this.dirs = default;
                this.files = default;
            }

            public fsTester(fs.FS fsys = default, slice<byte> errText = default, slice<@string> dirs = default, slice<@string> files = default)
            {
                this.fsys = fsys;
                this.errText = errText;
                this.dirs = dirs;
                this.files = files;
            }

            // Enable comparisons between nil and fsTester struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fsTester value, NilType nil) => value.Equals(default(fsTester));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fsTester value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fsTester value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fsTester value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fsTester(NilType nil) => default(fsTester);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static fsTester fsTester_cast(dynamic value)
        {
            return new fsTester(value.fsys, value.errText, value.dirs, value.files);
        }
    }
}}