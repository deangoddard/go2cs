//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:49 UTC
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
                this.Nlink = default;
                this.Mode = default;
                this.Padding0 = default;
                this.Uid = default;
                this.Gid = default;
                this.Padding1 = default;
                this.Rdev = default;
                this.Atim_ext = default;
                this.Atimespec = default;
                this.Mtim_ext = default;
                this.Mtimespec = default;
                this.Ctim_ext = default;
                this.Ctimespec = default;
                this.Btim_ext = default;
                this.Birthtimespec = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Spare = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, ulong Nlink = default, ushort Mode = default, short Padding0 = default, uint Uid = default, uint Gid = default, int Padding1 = default, ulong Rdev = default, int Atim_ext = default, Timespec Atimespec = default, int Mtim_ext = default, Timespec Mtimespec = default, int Ctim_ext = default, Timespec Ctimespec = default, int Btim_ext = default, Timespec Birthtimespec = default, long Size = default, long Blocks = default, int Blksize = default, uint Flags = default, ulong Gen = default, array<ulong> Spare = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Mode = Mode;
                this.Padding0 = Padding0;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Padding1 = Padding1;
                this.Rdev = Rdev;
                this.Atim_ext = Atim_ext;
                this.Atimespec = Atimespec;
                this.Mtim_ext = Mtim_ext;
                this.Mtimespec = Mtimespec;
                this.Ctim_ext = Ctim_ext;
                this.Ctimespec = Ctimespec;
                this.Btim_ext = Btim_ext;
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
            return new Stat_t(value.Dev, value.Ino, value.Nlink, value.Mode, value.Padding0, value.Uid, value.Gid, value.Padding1, value.Rdev, value.Atim_ext, value.Atimespec, value.Mtim_ext, value.Mtimespec, value.Ctim_ext, value.Ctimespec, value.Btim_ext, value.Birthtimespec, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Spare);
        }
    }
}