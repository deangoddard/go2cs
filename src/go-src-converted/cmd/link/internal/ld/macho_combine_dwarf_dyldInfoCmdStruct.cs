//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:21:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dyldInfoCmd
        {
            // Constructors
            public dyldInfoCmd(NilType _)
            {
                this.Cmd = default;
                this.Len = default;
                this.RebaseOff = default;
                this.RebaseLen = default;
                this.BindOff = default;
                this.BindLen = default;
                this.WeakBindOff = default;
                this.WeakBindLen = default;
                this.LazyBindOff = default;
                this.LazyBindLen = default;
                this.ExportOff = default;
                this.ExportLen = default;
            }

            public dyldInfoCmd(macho.LoadCmd Cmd = default, uint Len = default, uint RebaseOff = default, uint RebaseLen = default, uint BindOff = default, uint BindLen = default, uint WeakBindOff = default, uint WeakBindLen = default, uint LazyBindOff = default, uint LazyBindLen = default, uint ExportOff = default, uint ExportLen = default)
            {
                this.Cmd = Cmd;
                this.Len = Len;
                this.RebaseOff = RebaseOff;
                this.RebaseLen = RebaseLen;
                this.BindOff = BindOff;
                this.BindLen = BindLen;
                this.WeakBindOff = WeakBindOff;
                this.WeakBindLen = WeakBindLen;
                this.LazyBindOff = LazyBindOff;
                this.LazyBindLen = LazyBindLen;
                this.ExportOff = ExportOff;
                this.ExportLen = ExportLen;
            }

            // Enable comparisons between nil and dyldInfoCmd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dyldInfoCmd value, NilType nil) => value.Equals(default(dyldInfoCmd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dyldInfoCmd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dyldInfoCmd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dyldInfoCmd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dyldInfoCmd(NilType nil) => default(dyldInfoCmd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dyldInfoCmd dyldInfoCmd_cast(dynamic value)
        {
            return new dyldInfoCmd(value.Cmd, value.Len, value.RebaseOff, value.RebaseLen, value.BindOff, value.BindLen, value.WeakBindOff, value.WeakBindLen, value.LazyBindOff, value.LazyBindLen, value.ExportOff, value.ExportLen);
        }
    }
}}}}