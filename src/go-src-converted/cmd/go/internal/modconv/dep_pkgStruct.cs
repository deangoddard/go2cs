//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using lazyregexp = go.@internal.lazyregexp_package;
using url = go.net.url_package;
using path = go.path_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using modfile = go.golang.org.x.mod.modfile_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modconv_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pkg
        {
            // Constructors
            public pkg(NilType _)
            {
                this.Path = default;
                this.Version = default;
                this.Source = default;
            }

            public pkg(@string Path = default, @string Version = default, @string Source = default)
            {
                this.Path = Path;
                this.Version = Version;
                this.Source = Source;
            }

            // Enable comparisons between nil and pkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pkg value, NilType nil) => value.Equals(default(pkg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pkg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pkg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pkg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pkg(NilType nil) => default(pkg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pkg pkg_cast(dynamic value)
        {
            return new pkg(value.Path, value.Version, value.Source);
        }
    }
}}}}