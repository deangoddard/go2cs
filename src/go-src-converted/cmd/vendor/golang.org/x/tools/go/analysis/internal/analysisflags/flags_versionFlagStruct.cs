//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sha256 = go.crypto.sha256_package;
using gob = go.encoding.gob_package;
using json = go.encoding.json_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using token = go.go.token_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace @internal
{
    public static partial class analysisflags_package
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
}}}}}}}}}