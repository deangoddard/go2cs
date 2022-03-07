//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:48 UTC
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
                this.Nlink = default;
                this.Ino = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Pad_cgo_0 = default;
                this.Atimespec = default;
                this.Mtimespec = default;
                this.Ctimespec = default;
                this.Birthtimespec = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Lspare = default;
                this.Qspare = default;
            }

            public Stat_t(int Dev = default, ushort Mode = default, ushort Nlink = default, ulong Ino = default, uint Uid = default, uint Gid = default, int Rdev = default, array<byte> Pad_cgo_0 = default, Timespec Atimespec = default, Timespec Mtimespec = default, Timespec Ctimespec = default, Timespec Birthtimespec = default, long Size = default, long Blocks = default, int Blksize = default, uint Flags = default, uint Gen = default, int Lspare = default, array<long> Qspare = default)
            {
                this.Dev = Dev;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Ino = Ino;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Atimespec = Atimespec;
                this.Mtimespec = Mtimespec;
                this.Ctimespec = Ctimespec;
                this.Birthtimespec = Birthtimespec;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Lspare = Lspare;
                this.Qspare = Qspare;
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
            return new Stat_t(value.Dev, value.Mode, value.Nlink, value.Ino, value.Uid, value.Gid, value.Rdev, value.Pad_cgo_0, value.Atimespec, value.Mtimespec, value.Ctimespec, value.Birthtimespec, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Lspare, value.Qspare);
        }
    }
}