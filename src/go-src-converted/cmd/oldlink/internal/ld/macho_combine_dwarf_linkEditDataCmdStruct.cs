//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using zlib = go.compress.zlib_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct linkEditDataCmd
        {
            // Constructors
            public linkEditDataCmd(NilType _)
            {
                this.Cmd = default;
                this.Len = default;
                this.DataOff = default;
                this.DataLen = default;
            }

            public linkEditDataCmd(macho.LoadCmd Cmd = default, uint Len = default, uint DataOff = default, uint DataLen = default)
            {
                this.Cmd = Cmd;
                this.Len = Len;
                this.DataOff = DataOff;
                this.DataLen = DataLen;
            }

            // Enable comparisons between nil and linkEditDataCmd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(linkEditDataCmd value, NilType nil) => value.Equals(default(linkEditDataCmd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(linkEditDataCmd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, linkEditDataCmd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, linkEditDataCmd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator linkEditDataCmd(NilType nil) => default(linkEditDataCmd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static linkEditDataCmd linkEditDataCmd_cast(dynamic value)
        {
            return new linkEditDataCmd(value.Cmd, value.Len, value.DataOff, value.DataLen);
        }
    }
}}}}