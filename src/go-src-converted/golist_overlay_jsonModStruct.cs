//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using log = go.log_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class packages_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct jsonMod
        {
            // Constructors
            public jsonMod(NilType _)
            {
                this.Path = default;
                this.Dir = default;
            }

            public jsonMod(@string Path = default, @string Dir = default)
            {
                this.Path = Path;
                this.Dir = Dir;
            }

            // Enable comparisons between nil and jsonMod struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(jsonMod value, NilType nil) => value.Equals(default(jsonMod));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(jsonMod value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, jsonMod value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, jsonMod value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator jsonMod(NilType nil) => default(jsonMod);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static jsonMod jsonMod_cast(dynamic value)
        {
            return new jsonMod(value.Path, value.Dir);
        }
    }
}}}}}