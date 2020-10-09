//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:36 UTC
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
                this.Dev = default;
                this.Ino = default;
                this.Mode = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Size = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.Blksize = default;
                this.Pad_cgo_0 = default;
                this.Blocks = default;
                this.Fstype = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, uint Mode = default, uint Nlink = default, uint Uid = default, uint Gid = default, ulong Rdev = default, long Size = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, int Blksize = default, array<byte> Pad_cgo_0 = default, long Blocks = default, array<sbyte> Fstype = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Size = Size;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.Blksize = Blksize;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Blocks = Blocks;
                this.Fstype = Fstype;
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
            return new Stat_t(value.Dev, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Size, value.Atim, value.Mtim, value.Ctim, value.Blksize, value.Pad_cgo_0, value.Blocks, value.Fstype);
        }
    }
}