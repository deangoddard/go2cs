//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct importer
        {
            // Constructors
            public importer(NilType _)
            {
                this.imports = default;
                this.data = default;
                this.importpath = default;
                this.buf = default;
                this.version = default;
                this.strList = default;
                this.pathList = default;
                this.pkgList = default;
                this.typList = default;
                this.interfaceList = default;
                this.trackAllTypes = default;
                this.posInfoFormat = default;
                this.prevFile = default;
                this.prevLine = default;
                this.fset = default;
                this.files = default;
                this.debugFormat = default;
                this.read = default;
            }

            public importer(map<@string, ref types.Package> imports = default, slice<byte> data = default, @string importpath = default, slice<byte> buf = default, long version = default, slice<@string> strList = default, slice<@string> pathList = default, slice<ref types.Package> pkgList = default, slice<types.Type> typList = default, slice<ref types.Interface> interfaceList = default, bool trackAllTypes = default, bool posInfoFormat = default, @string prevFile = default, long prevLine = default, ref ptr<token.FileSet> fset = default, map<@string, ref token.File> files = default, bool debugFormat = default, long read = default)
            {
                this.imports = imports;
                this.data = data;
                this.importpath = importpath;
                this.buf = buf;
                this.version = version;
                this.strList = strList;
                this.pathList = pathList;
                this.pkgList = pkgList;
                this.typList = typList;
                this.interfaceList = interfaceList;
                this.trackAllTypes = trackAllTypes;
                this.posInfoFormat = posInfoFormat;
                this.prevFile = prevFile;
                this.prevLine = prevLine;
                this.fset = fset;
                this.files = files;
                this.debugFormat = debugFormat;
                this.read = read;
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
            return new importer(value.imports, value.data, value.importpath, value.buf, value.version, value.strList, value.pathList, value.pkgList, value.typList, value.interfaceList, value.trackAllTypes, value.posInfoFormat, value.prevFile, value.prevLine, ref value.fset, value.files, value.debugFormat, value.read);
        }
    }
}}}