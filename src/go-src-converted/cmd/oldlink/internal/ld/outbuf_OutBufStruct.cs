//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using binary = go.encoding.binary_package;
using log = go.log_package;
using os = go.os_package;
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
        public partial struct OutBuf
        {
            // Constructors
            public OutBuf(NilType _)
            {
                this.arch = default;
                this.off = default;
                this.w = default;
                this.buf = default;
                this.f = default;
                this.encbuf = default;
            }

            public OutBuf(ref ptr<sys.Arch> arch = default, long off = default, ref ptr<bufio.Writer> w = default, slice<byte> buf = default, ref ptr<os.File> f = default, array<byte> encbuf = default)
            {
                this.arch = arch;
                this.off = off;
                this.w = w;
                this.buf = buf;
                this.f = f;
                this.encbuf = encbuf;
            }

            // Enable comparisons between nil and OutBuf struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OutBuf value, NilType nil) => value.Equals(default(OutBuf));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OutBuf value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OutBuf value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OutBuf value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator OutBuf(NilType nil) => default(OutBuf);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static OutBuf OutBuf_cast(dynamic value)
        {
            return new OutBuf(ref value.arch, value.off, ref value.w, value.buf, ref value.f, value.encbuf);
        }
    }
}}}}