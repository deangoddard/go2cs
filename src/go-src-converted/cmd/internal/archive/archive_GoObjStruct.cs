//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:32:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using goobj = go.cmd.@internal.goobj_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class archive_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(Data))]
        public partial struct GoObj
        {
            // Data structure promotion - sourced from value copy
            private readonly ptr<Data> m_DataRef;

            private ref Data Data_val => ref m_DataRef.Value;

            public ref long Offset => ref m_DataRef.Value.Offset;

            public ref long Size => ref m_DataRef.Value.Size;

            // Constructors
            public GoObj(NilType _)
            {
                this.TextHeader = default;
                this.Arch = default;
                this.m_DataRef = new ptr<Data>(new Data(nil));
            }

            public GoObj(slice<byte> TextHeader = default, @string Arch = default, Data Data = default)
            {
                this.TextHeader = TextHeader;
                this.Arch = Arch;
                this.m_DataRef = new ptr<Data>(Data);
            }

            // Enable comparisons between nil and GoObj struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(GoObj value, NilType nil) => value.Equals(default(GoObj));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(GoObj value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, GoObj value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, GoObj value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator GoObj(NilType nil) => default(GoObj);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static GoObj GoObj_cast(dynamic value)
        {
            return new GoObj(value.TextHeader, value.Arch, value.Data);
        }
    }
}}}