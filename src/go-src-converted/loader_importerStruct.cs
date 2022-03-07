//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:33:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using astutil = go.golang.org.x.tools.go.ast.astutil_package;
using cgo = go.golang.org.x.tools.go.@internal.cgo_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct importer
        {
            // Constructors
            public importer(NilType _)
            {
                this.conf = default;
                this.start = default;
                this.progMu = default;
                this.prog = default;
                this.findpkgMu = default;
                this.findpkg = default;
                this.importedMu = default;
                this.imported = default;
                this.graphMu = default;
                this.graph = default;
            }

            public importer(ref ptr<Config> conf = default, time.Time start = default, sync.Mutex progMu = default, ref ptr<Program> prog = default, sync.Mutex findpkgMu = default, map<findpkgKey, ptr<findpkgValue>> findpkg = default, sync.Mutex importedMu = default, map<@string, ptr<importInfo>> imported = default, sync.Mutex graphMu = default, map<@string, map<@string, bool>> graph = default)
            {
                this.conf = conf;
                this.start = start;
                this.progMu = progMu;
                this.prog = prog;
                this.findpkgMu = findpkgMu;
                this.findpkg = findpkg;
                this.importedMu = importedMu;
                this.imported = imported;
                this.graphMu = graphMu;
                this.graph = graph;
            }

            // Enable comparisons between nil and importer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importer value, NilType nil) => value.Equals(default(importer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importer(NilType nil) => default(importer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importer importer_cast(dynamic value)
        {
            return new importer(ref value.conf, value.start, value.progMu, ref value.prog, value.findpkgMu, value.findpkg, value.importedMu, value.imported, value.graphMu, value.graph);
        }
    }
}}}}}