//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using doc = go.go.doc_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using pathpkg = go.path_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class build_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MultiplePackageError
        {
            // Constructors
            public MultiplePackageError(NilType _)
            {
                this.Dir = default;
                this.Packages = default;
                this.Files = default;
            }

            public MultiplePackageError(@string Dir = default, slice<@string> Packages = default, slice<@string> Files = default)
            {
                this.Dir = Dir;
                this.Packages = Packages;
                this.Files = Files;
            }

            // Enable comparisons between nil and MultiplePackageError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MultiplePackageError value, NilType nil) => value.Equals(default(MultiplePackageError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MultiplePackageError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MultiplePackageError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MultiplePackageError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MultiplePackageError(NilType nil) => default(MultiplePackageError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MultiplePackageError MultiplePackageError_cast(dynamic value)
        {
            return new MultiplePackageError(value.Dir, value.Packages, value.Files);
        }
    }
}}