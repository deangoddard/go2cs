//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:30:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using context = go.context_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using doc = go.go.doc_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using lazytemplate = go.@internal.lazytemplate_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using fsys = go.cmd.go.@internal.fsys_package;
using str = go.cmd.go.@internal.str_package;
using trace = go.cmd.go.@internal.trace_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class load_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct testFuncs
        {
            // Constructors
            public testFuncs(NilType _)
            {
                this.Tests = default;
                this.Benchmarks = default;
                this.Examples = default;
                this.TestMain = default;
                this.Package = default;
                this.ImportTest = default;
                this.NeedTest = default;
                this.ImportXtest = default;
                this.NeedXtest = default;
                this.Cover = default;
            }

            public testFuncs(slice<testFunc> Tests = default, slice<testFunc> Benchmarks = default, slice<testFunc> Examples = default, ref ptr<testFunc> TestMain = default, ref ptr<Package> Package = default, bool ImportTest = default, bool NeedTest = default, bool ImportXtest = default, bool NeedXtest = default, ref ptr<TestCover> Cover = default)
            {
                this.Tests = Tests;
                this.Benchmarks = Benchmarks;
                this.Examples = Examples;
                this.TestMain = TestMain;
                this.Package = Package;
                this.ImportTest = ImportTest;
                this.NeedTest = NeedTest;
                this.ImportXtest = ImportXtest;
                this.NeedXtest = NeedXtest;
                this.Cover = Cover;
            }

            // Enable comparisons between nil and testFuncs struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(testFuncs value, NilType nil) => value.Equals(default(testFuncs));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(testFuncs value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, testFuncs value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, testFuncs value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator testFuncs(NilType nil) => default(testFuncs);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static testFuncs testFuncs_cast(dynamic value)
        {
            return new testFuncs(value.Tests, value.Benchmarks, value.Examples, ref value.TestMain, ref value.Package, value.ImportTest, value.NeedTest, value.ImportXtest, value.NeedXtest, ref value.Cover);
        }
    }
}}}}