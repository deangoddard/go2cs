//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:32 UTC
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
        private partial struct statfs_freebsd11_t
        {
            // Constructors
            public statfs_freebsd11_t(NilType _)
            {
                this.Version = default;
                this.Type = default;
                this.Flags = default;
                this.Bsize = default;
                this.Iosize = default;
                this.Blocks = default;
                this.Bfree = default;
                this.Bavail = default;
                this.Files = default;
                this.Ffree = default;
                this.Syncwrites = default;
                this.Asyncwrites = default;
                this.Syncreads = default;
                this.Asyncreads = default;
                this.Spare = default;
                this.Namemax = default;
                this.Owner = default;
                this.Fsid = default;
                this.Charspare = default;
                this.Fstypename = default;
                this.Mntfromname = default;
                this.Mntonname = default;
            }

            public statfs_freebsd11_t(uint Version = default, uint Type = default, ulong Flags = default, ulong Bsize = default, ulong Iosize = default, ulong Blocks = default, ulong Bfree = default, long Bavail = default, ulong Files = default, long Ffree = default, ulong Syncwrites = default, ulong Asyncwrites = default, ulong Syncreads = default, ulong Asyncreads = default, array<ulong> Spare = default, uint Namemax = default, uint Owner = default, Fsid Fsid = default, array<sbyte> Charspare = default, array<byte> Fstypename = default, array<byte> Mntfromname = default, array<byte> Mntonname = default)
            {
                this.Version = Version;
                this.Type = Type;
                this.Flags = Flags;
                this.Bsize = Bsize;
                this.Iosize = Iosize;
                this.Blocks = Blocks;
                this.Bfree = Bfree;
                this.Bavail = Bavail;
                this.Files = Files;
                this.Ffree = Ffree;
                this.Syncwrites = Syncwrites;
                this.Asyncwrites = Asyncwrites;
                this.Syncreads = Syncreads;
                this.Asyncreads = Asyncreads;
                this.Spare = Spare;
                this.Namemax = Namemax;
                this.Owner = Owner;
                this.Fsid = Fsid;
                this.Charspare = Charspare;
                this.Fstypename = Fstypename;
                this.Mntfromname = Mntfromname;
                this.Mntonname = Mntonname;
            }

            // Enable comparisons between nil and statfs_freebsd11_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(statfs_freebsd11_t value, NilType nil) => value.Equals(default(statfs_freebsd11_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(statfs_freebsd11_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, statfs_freebsd11_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, statfs_freebsd11_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator statfs_freebsd11_t(NilType nil) => default(statfs_freebsd11_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static statfs_freebsd11_t statfs_freebsd11_t_cast(dynamic value)
        {
            return new statfs_freebsd11_t(value.Version, value.Type, value.Flags, value.Bsize, value.Iosize, value.Blocks, value.Bfree, value.Bavail, value.Files, value.Ffree, value.Syncwrites, value.Asyncwrites, value.Syncreads, value.Asyncreads, value.Spare, value.Namemax, value.Owner, value.Fsid, value.Charspare, value.Fstypename, value.Mntfromname, value.Mntonname);
        }
    }
}}}}}}