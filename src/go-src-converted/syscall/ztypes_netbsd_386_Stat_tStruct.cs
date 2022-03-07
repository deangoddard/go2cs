//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:50 UTC
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
                this.Mode = default;
                this.Ino = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Atimespec = default;
                this.Mtimespec = default;
                this.Ctimespec = default;
                this.Birthtimespec = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Spare = default;
            }

            public Stat_t(ulong Dev = default, uint Mode = default, ulong Ino = default, uint Nlink = default, uint Uid = default, uint Gid = default, ulong Rdev = default, Timespec Atimespec = default, Timespec Mtimespec = default, Timespec Ctimespec = default, Timespec Birthtimespec = default, long Size = default, long Blocks = default, uint Blksize = default, uint Flags = default, uint Gen = default, array<uint> Spare = default)
            {
                this.Dev = Dev;
                this.Mode = Mode;
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Atimespec = Atimespec;
                this.Mtimespec = Mtimespec;
                this.Ctimespec = Ctimespec;
                this.Birthtimespec = Birthtimespec;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Spare = Spare;
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
            return new Stat_t(value.Dev, value.Mode, value.Ino, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Atimespec, value.Mtimespec, value.Ctimespec, value.Birthtimespec, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Spare);
        }
    }
}