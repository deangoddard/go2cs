//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:06:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using tls = go.crypto.tls_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using http = go.net.http_package;
using url = go.net.url_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using binutils = go.github.com.google.pprof.@internal.binutils_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using symbolz = go.github.com.google.pprof.@internal.symbolz_package;
using profile = go.github.com.google.pprof.profile_package;
using demangle = go.github.com.ianlancetaylor.demangle_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class symbolizer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Symbolizer
        {
            // Constructors
            public Symbolizer(NilType _)
            {
                this.Obj = default;
                this.UI = default;
            }

            public Symbolizer(plugin.ObjTool Obj = default, plugin.UI UI = default)
            {
                this.Obj = Obj;
                this.UI = UI;
            }

            // Enable comparisons between nil and Symbolizer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Symbolizer value, NilType nil) => value.Equals(default(Symbolizer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Symbolizer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Symbolizer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Symbolizer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Symbolizer(NilType nil) => default(Symbolizer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Symbolizer Symbolizer_cast(dynamic value)
        {
            return new Symbolizer(value.Obj, value.UI);
        }
    }
}}}}}}}