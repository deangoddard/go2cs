//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct zipError
        {
            // Constructors
            public zipError(NilType _)
            {
                this.verb = default;
                this.path = default;
                this.err = default;
            }

            public zipError(@string verb = default, @string path = default, error err = default)
            {
                this.verb = verb;
                this.path = path;
                this.err = err;
            }

            // Enable comparisons between nil and zipError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(zipError value, NilType nil) => value.Equals(default(zipError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(zipError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, zipError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, zipError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator zipError(NilType nil) => default(zipError);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static zipError zipError_cast(dynamic value)
        {
            return new zipError(value.verb, value.path, value.err);
        }
    }
}}}}}}