//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:11 UTC
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
using io = go.io_package;
using exec = go.os.exec_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class binutils_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct symbolInfo
        {
            // Constructors
            public symbolInfo(NilType _)
            {
                this.address = default;
                this.name = default;
            }

            public symbolInfo(ulong address = default, @string name = default)
            {
                this.address = address;
                this.name = name;
            }

            // Enable comparisons between nil and symbolInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(symbolInfo value, NilType nil) => value.Equals(default(symbolInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(symbolInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, symbolInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, symbolInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator symbolInfo(NilType nil) => default(symbolInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static symbolInfo symbolInfo_cast(dynamic value)
        {
            return new symbolInfo(value.address, value.name);
        }
    }
}}}}}}}