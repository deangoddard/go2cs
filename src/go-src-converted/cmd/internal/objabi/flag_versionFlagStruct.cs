//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:43:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using buildcfg = go.@internal.buildcfg_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class objabi_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct versionFlag
        {
            // Constructors
            public versionFlag(NilType _)
            {
            }
            // Enable comparisons between nil and versionFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(versionFlag value, NilType nil) => value.Equals(default(versionFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(versionFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, versionFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, versionFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator versionFlag(NilType nil) => default(versionFlag);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static versionFlag versionFlag_cast(dynamic value)
        {
            return new versionFlag();
        }
    }
}}}