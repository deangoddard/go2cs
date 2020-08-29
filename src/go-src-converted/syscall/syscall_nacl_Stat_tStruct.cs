//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:38:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

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
                this.Blksize = default;
                this.Blocks = default;
                this.Atime = default;
                this.AtimeNsec = default;
                this.Mtime = default;
                this.MtimeNsec = default;
                this.Ctime = default;
                this.CtimeNsec = default;
            }

            public Stat_t(long Dev = default, ulong Ino = default, uint Mode = default, uint Nlink = default, uint Uid = default, uint Gid = default, long Rdev = default, long Size = default, int Blksize = default, int Blocks = default, long Atime = default, long AtimeNsec = default, long Mtime = default, long MtimeNsec = default, long Ctime = default, long CtimeNsec = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Size = Size;
                this.Blksize = Blksize;
                this.Blocks = Blocks;
                this.Atime = Atime;
                this.AtimeNsec = AtimeNsec;
                this.Mtime = Mtime;
                this.MtimeNsec = MtimeNsec;
                this.Ctime = Ctime;
                this.CtimeNsec = CtimeNsec;
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
            return new Stat_t(value.Dev, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Size, value.Blksize, value.Blocks, value.Atime, value.AtimeNsec, value.Mtime, value.MtimeNsec, value.Ctime, value.CtimeNsec);
        }
    }
}