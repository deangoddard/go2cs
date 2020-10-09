//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Walker
        {
            // Constructors
            public Walker(NilType _)
            {
                this.context = default;
                this.root = default;
                this.scope = default;
                this.current = default;
                this.features = default;
                this.imported = default;
                this.stdPackages = default;
                this.importMap = default;
                this.importDir = default;
            }

            public Walker(ref ptr<build.Context> context = default, @string root = default, slice<@string> scope = default, ref ptr<types.Package> current = default, map<@string, bool> features = default, map<@string, ptr<types.Package>> imported = default, slice<@string> stdPackages = default, map<@string, map<@string, @string>> importMap = default, map<@string, @string> importDir = default)
            {
                this.context = context;
                this.root = root;
                this.scope = scope;
                this.current = current;
                this.features = features;
                this.imported = imported;
                this.stdPackages = stdPackages;
                this.importMap = importMap;
                this.importDir = importDir;
            }

            // Enable comparisons between nil and Walker struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Walker value, NilType nil) => value.Equals(default(Walker));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Walker value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Walker value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Walker value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Walker(NilType nil) => default(Walker);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Walker Walker_cast(dynamic value)
        {
            return new Walker(ref value.context, value.root, value.scope, ref value.current, value.features, value.imported, value.stdPackages, value.importMap, value.importDir);
        }
    }
}