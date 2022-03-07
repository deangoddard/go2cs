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
        public partial struct Statvfs_t
        {
            // Constructors
            public Statvfs_t(NilType _)
            {
                this.Flag = default;
                this.Bsize = default;
                this.Frsize = default;
                this.Iosize = default;
                this.Blocks = default;
                this.Bfree = default;
                this.Bavail = default;
                this.Bresvd = default;
                this.Files = default;
                this.Ffree = default;
                this.Favail = default;
                this.Fresvd = default;
                this.Syncreads = default;
                this.Syncwrites = default;
                this.Asyncreads = default;
                this.Asyncwrites = default;
                this.Fsidx = default;
                this.Fsid = default;
                this.Namemax = default;
                this.Owner = default;
                this.Spare = default;
                this.Fstypename = default;
                this.Mntonname = default;
                this.Mntfromname = default;
            }

            public Statvfs_t(uint Flag = default, uint Bsize = default, uint Frsize = default, uint Iosize = default, ulong Blocks = default, ulong Bfree = default, ulong Bavail = default, ulong Bresvd = default, ulong Files = default, ulong Ffree = default, ulong Favail = default, ulong Fresvd = default, ulong Syncreads = default, ulong Syncwrites = default, ulong Asyncreads = default, ulong Asyncwrites = default, Fsid Fsidx = default, uint Fsid = default, uint Namemax = default, uint Owner = default, array<uint> Spare = default, array<byte> Fstypename = default, array<byte> Mntonname = default, array<byte> Mntfromname = default)
            {
                this.Flag = Flag;
                this.Bsize = Bsize;
                this.Frsize = Frsize;
                this.Iosize = Iosize;
                this.Blocks = Blocks;
                this.Bfree = Bfree;
                this.Bavail = Bavail;
                this.Bresvd = Bresvd;
                this.Files = Files;
                this.Ffree = Ffree;
                this.Favail = Favail;
                this.Fresvd = Fresvd;
                this.Syncreads = Syncreads;
                this.Syncwrites = Syncwrites;
                this.Asyncreads = Asyncreads;
                this.Asyncwrites = Asyncwrites;
                this.Fsidx = Fsidx;
                this.Fsid = Fsid;
                this.Namemax = Namemax;
                this.Owner = Owner;
                this.Spare = Spare;
                this.Fstypename = Fstypename;
                this.Mntonname = Mntonname;
                this.Mntfromname = Mntfromname;
            }

            // Enable comparisons between nil and Statvfs_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Statvfs_t value, NilType nil) => value.Equals(default(Statvfs_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Statvfs_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Statvfs_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Statvfs_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Statvfs_t(NilType nil) => default(Statvfs_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Statvfs_t Statvfs_t_cast(dynamic value)
        {
            return new Statvfs_t(value.Flag, value.Bsize, value.Frsize, value.Iosize, value.Blocks, value.Bfree, value.Bavail, value.Bresvd, value.Files, value.Ffree, value.Favail, value.Fresvd, value.Syncreads, value.Syncwrites, value.Asyncreads, value.Asyncwrites, value.Fsidx, value.Fsid, value.Namemax, value.Owner, value.Spare, value.Fstypename, value.Mntonname, value.Mntfromname);
        }
    }
}}}}}}