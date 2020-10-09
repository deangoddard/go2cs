//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Stat_t
        {
            // Constructors
            public Stat_t(NilType _)
            {
                this.Mode = default;
                this.Dev = default;
                this.Ino = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Pad_cgo_0 = default;
                this.X__st_birthtim = default;
            }

            public Stat_t(uint Mode = default, int Dev = default, ulong Ino = default, uint Nlink = default, uint Uid = default, uint Gid = default, int Rdev = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, long Size = default, long Blocks = default, uint Blksize = default, uint Flags = default, uint Gen = default, array<byte> Pad_cgo_0 = default, Timespec X__st_birthtim = default)
            {
                this.Mode = Mode;
                this.Dev = Dev;
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.X__st_birthtim = X__st_birthtim;
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
            return new Stat_t(value.Mode, value.Dev, value.Ino, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Atim, value.Mtim, value.Ctim, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Pad_cgo_0, value.X__st_birthtim);
        }
    }
}