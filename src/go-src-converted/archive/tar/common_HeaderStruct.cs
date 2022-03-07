//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using errors = go.errors_package;
using fmt = go.fmt_package;
using fs = go.io.fs_package;
using math = go.math_package;
using path = go.path_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Header
        {
            // Constructors
            public Header(NilType _)
            {
                this.Typeflag = default;
                this.Name = default;
                this.Linkname = default;
                this.Size = default;
                this.Mode = default;
                this.Uid = default;
                this.Gid = default;
                this.Uname = default;
                this.Gname = default;
                this.ModTime = default;
                this.AccessTime = default;
                this.ChangeTime = default;
                this.Devmajor = default;
                this.Devminor = default;
                this.Xattrs = default;
                this.PAXRecords = default;
                this.Format = default;
            }

            public Header(byte Typeflag = default, @string Name = default, @string Linkname = default, long Size = default, long Mode = default, nint Uid = default, nint Gid = default, @string Uname = default, @string Gname = default, time.Time ModTime = default, time.Time AccessTime = default, time.Time ChangeTime = default, long Devmajor = default, long Devminor = default, map<@string, @string> Xattrs = default, map<@string, @string> PAXRecords = default, Format Format = default)
            {
                this.Typeflag = Typeflag;
                this.Name = Name;
                this.Linkname = Linkname;
                this.Size = Size;
                this.Mode = Mode;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Uname = Uname;
                this.Gname = Gname;
                this.ModTime = ModTime;
                this.AccessTime = AccessTime;
                this.ChangeTime = ChangeTime;
                this.Devmajor = Devmajor;
                this.Devminor = Devminor;
                this.Xattrs = Xattrs;
                this.PAXRecords = PAXRecords;
                this.Format = Format;
            }

            // Enable comparisons between nil and Header struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Header value, NilType nil) => value.Equals(default(Header));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Header value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Header value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Header value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Header(NilType nil) => default(Header);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Header Header_cast(dynamic value)
        {
            return new Header(value.Typeflag, value.Name, value.Linkname, value.Size, value.Mode, value.Uid, value.Gid, value.Uname, value.Gname, value.ModTime, value.AccessTime, value.ChangeTime, value.Devmajor, value.Devminor, value.Xattrs, value.PAXRecords, value.Format);
        }
    }
}}