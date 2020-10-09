//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Statx_t
        {
            // Constructors
            public Statx_t(NilType _)
            {
                this.Mask = default;
                this.Blksize = default;
                this.Attributes = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Mode = default;
                this._ = default;
                this.Ino = default;
                this.Size = default;
                this.Blocks = default;
                this.Attributes_mask = default;
                this.Atime = default;
                this.Btime = default;
                this.Ctime = default;
                this.Mtime = default;
                this.Rdev_major = default;
                this.Rdev_minor = default;
                this.Dev_major = default;
                this.Dev_minor = default;
                this._ = default;
            }

            public Statx_t(uint Mask = default, uint Blksize = default, ulong Attributes = default, uint Nlink = default, uint Uid = default, uint Gid = default, ushort Mode = default, array<ushort> _ = default, ulong Ino = default, ulong Size = default, ulong Blocks = default, ulong Attributes_mask = default, StatxTimestamp Atime = default, StatxTimestamp Btime = default, StatxTimestamp Ctime = default, StatxTimestamp Mtime = default, uint Rdev_major = default, uint Rdev_minor = default, uint Dev_major = default, uint Dev_minor = default, array<ulong> _ = default)
            {
                this.Mask = Mask;
                this.Blksize = Blksize;
                this.Attributes = Attributes;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Mode = Mode;
                this._ = _;
                this.Ino = Ino;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Attributes_mask = Attributes_mask;
                this.Atime = Atime;
                this.Btime = Btime;
                this.Ctime = Ctime;
                this.Mtime = Mtime;
                this.Rdev_major = Rdev_major;
                this.Rdev_minor = Rdev_minor;
                this.Dev_major = Dev_major;
                this.Dev_minor = Dev_minor;
                this._ = _;
            }

            // Enable comparisons between nil and Statx_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Statx_t value, NilType nil) => value.Equals(default(Statx_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Statx_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Statx_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Statx_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Statx_t(NilType nil) => default(Statx_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Statx_t Statx_t_cast(dynamic value)
        {
            return new Statx_t(value.Mask, value.Blksize, value.Attributes, value.Nlink, value.Uid, value.Gid, value.Mode, value._, value.Ino, value.Size, value.Blocks, value.Attributes_mask, value.Atime, value.Btime, value.Ctime, value.Mtime, value.Rdev_major, value.Rdev_minor, value.Dev_major, value.Dev_minor, value._);
        }
    }
}}}}}}