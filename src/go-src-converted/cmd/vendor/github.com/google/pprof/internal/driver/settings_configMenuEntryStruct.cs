//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:23:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using ioutil = go.io.ioutil_package;
using url = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct configMenuEntry
        {
            // Constructors
            public configMenuEntry(NilType _)
            {
                this.Name = default;
                this.URL = default;
                this.Current = default;
                this.UserConfig = default;
            }

            public configMenuEntry(@string Name = default, @string URL = default, bool Current = default, bool UserConfig = default)
            {
                this.Name = Name;
                this.URL = URL;
                this.Current = Current;
                this.UserConfig = UserConfig;
            }

            // Enable comparisons between nil and configMenuEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(configMenuEntry value, NilType nil) => value.Equals(default(configMenuEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(configMenuEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, configMenuEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, configMenuEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator configMenuEntry(NilType nil) => default(configMenuEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static configMenuEntry configMenuEntry_cast(dynamic value)
        {
            return new configMenuEntry(value.Name, value.URL, value.Current, value.UserConfig);
        }
    }
}}}}}}}