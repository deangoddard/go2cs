//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using singleflight = go.@internal.singleflight_package;
using log = go.log_package;
using url = go.net.url_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using web = go.cmd.go.@internal.web_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class get_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fetchResult
        {
            // Constructors
            public fetchResult(NilType _)
            {
                this.urlStr = default;
                this.imports = default;
                this.err = default;
            }

            public fetchResult(@string urlStr = default, slice<metaImport> imports = default, error err = default)
            {
                this.urlStr = urlStr;
                this.imports = imports;
                this.err = err;
            }

            // Enable comparisons between nil and fetchResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fetchResult value, NilType nil) => value.Equals(default(fetchResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fetchResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fetchResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fetchResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fetchResult(NilType nil) => default(fetchResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fetchResult fetchResult_cast(dynamic value)
        {
            return new fetchResult(value.urlStr, value.imports, value.err);
        }
    }
}}}}