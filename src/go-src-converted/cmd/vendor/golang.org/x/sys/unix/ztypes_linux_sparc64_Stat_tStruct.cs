//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:31 UTC
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
        public partial struct Stat_t
        {
            // Constructors
            public Stat_t(NilType _)
            {
                this.Dev = default;
                this._ = default;
                this.Ino = default;
                this.Mode = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this._ = default;
                this.Size = default;
                this.Blksize = default;
                this.Blocks = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this._ = default;
                this._ = default;
            }

            public Stat_t(ulong Dev = default, ushort _ = default, ulong Ino = default, uint Mode = default, uint Nlink = default, uint Uid = default, uint Gid = default, ulong Rdev = default, ushort _ = default, long Size = default, long Blksize = default, long Blocks = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, ulong _ = default, ulong _ = default)
            {
                this.Dev = Dev;
                this._ = _;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this._ = _;
                this.Size = Size;
                this.Blksize = Blksize;
                this.Blocks = Blocks;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this._ = _;
                this._ = _;
            }

            // Enable comparisons between nil and Stat_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Stat_t value, NilType nil) => value.Equals(default(Stat_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Stat_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Stat_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Stat_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Stat_t(NilType nil) => default(Stat_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Stat_t Stat_t_cast(dynamic value)
        {
            return new Stat_t(value.Dev, value._, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value._, value.Size, value.Blksize, value.Blocks, value.Atim, value.Mtim, value.Ctim, value._, value._);
        }
    }
}}}}}}