//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:01:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using doc = go.go.doc_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using exec = go.os.exec_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using template = go.text.template_package;
using time = go.time_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @base = go.cmd.go.@internal.@base_package;
using cache = go.cmd.go.@internal.cache_package;
using cfg = go.cmd.go.@internal.cfg_package;
using load = go.cmd.go.@internal.load_package;
using str = go.cmd.go.@internal.str_package;
using work = go.cmd.go.@internal.work_package;
using test2json = go.cmd.@internal.test2json_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class test_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct testFunc
        {
            // Constructors
            public testFunc(NilType _)
            {
                this.Package = default;
                this.Name = default;
                this.Output = default;
                this.Unordered = default;
            }

            public testFunc(@string Package = default, @string Name = default, @string Output = default, bool Unordered = default)
            {
                this.Package = Package;
                this.Name = Name;
                this.Output = Output;
                this.Unordered = Unordered;
            }

            // Enable comparisons between nil and testFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testFunc value, NilType nil) => value.Equals(default(testFunc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testFunc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testFunc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testFunc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testFunc(NilType nil) => default(testFunc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static testFunc testFunc_cast(dynamic value)
        {
            return new testFunc(value.Package, value.Name, value.Output, value.Unordered);
        }
    }
}}}}