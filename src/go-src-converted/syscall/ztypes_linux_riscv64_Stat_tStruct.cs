//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:31 UTC
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
                this.X__pad1 = default;
                this.Size = default;
                this.Blksize = default;
                this.X__pad2 = default;
                this.Blocks = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.X__glibc_reserved = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, uint Mode = default, uint Nlink = default, uint Uid = default, uint Gid = default, ulong Rdev = default, ulong X__pad1 = default, long Size = default, int Blksize = default, int X__pad2 = default, long Blocks = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, array<int> X__glibc_reserved = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.X__pad1 = X__pad1;
                this.Size = Size;
                this.Blksize = Blksize;
                this.X__pad2 = X__pad2;
                this.Blocks = Blocks;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.X__glibc_reserved = X__glibc_reserved;
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
            return new Stat_t(value.Dev, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value.X__pad1, value.Size, value.Blksize, value.X__pad2, value.Blocks, value.Atim, value.Mtim, value.Ctim, value.X__glibc_reserved);
        }
    }
}