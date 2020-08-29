//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Statfs_t
        {
            // Constructors
            public Statfs_t(NilType _)
            {
                this.F_flags = default;
                this.F_bsize = default;
                this.F_iosize = default;
                this.F_blocks = default;
                this.F_bfree = default;
                this.F_bavail = default;
                this.F_files = default;
                this.F_ffree = default;
                this.F_favail = default;
                this.F_syncwrites = default;
                this.F_syncreads = default;
                this.F_asyncwrites = default;
                this.F_asyncreads = default;
                this.F_fsid = default;
                this.F_namemax = default;
                this.F_owner = default;
                this.F_ctime = default;
                this.F_fstypename = default;
                this.F_mntonname = default;
                this.F_mntfromname = default;
                this.F_mntfromspec = default;
                this.Pad_cgo_0 = default;
                this.Mount_info = default;
            }

            public Statfs_t(uint F_flags = default, uint F_bsize = default, uint F_iosize = default, ulong F_blocks = default, ulong F_bfree = default, long F_bavail = default, ulong F_files = default, ulong F_ffree = default, long F_favail = default, ulong F_syncwrites = default, ulong F_syncreads = default, ulong F_asyncwrites = default, ulong F_asyncreads = default, Fsid F_fsid = default, uint F_namemax = default, uint F_owner = default, ulong F_ctime = default, array<sbyte> F_fstypename = default, array<sbyte> F_mntonname = default, array<sbyte> F_mntfromname = default, array<sbyte> F_mntfromspec = default, array<byte> Pad_cgo_0 = default, array<byte> Mount_info = default)
            {
                this.F_flags = F_flags;
                this.F_bsize = F_bsize;
                this.F_iosize = F_iosize;
                this.F_blocks = F_blocks;
                this.F_bfree = F_bfree;
                this.F_bavail = F_bavail;
                this.F_files = F_files;
                this.F_ffree = F_ffree;
                this.F_favail = F_favail;
                this.F_syncwrites = F_syncwrites;
                this.F_syncreads = F_syncreads;
                this.F_asyncwrites = F_asyncwrites;
                this.F_asyncreads = F_asyncreads;
                this.F_fsid = F_fsid;
                this.F_namemax = F_namemax;
                this.F_owner = F_owner;
                this.F_ctime = F_ctime;
                this.F_fstypename = F_fstypename;
                this.F_mntonname = F_mntonname;
                this.F_mntfromname = F_mntfromname;
                this.F_mntfromspec = F_mntfromspec;
                this.Pad_cgo_0 = Pad_cgo_0;
                this.Mount_info = Mount_info;
            }

            // Enable comparisons between nil and Statfs_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Statfs_t value, NilType nil) => value.Equals(default(Statfs_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Statfs_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Statfs_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Statfs_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Statfs_t(NilType nil) => default(Statfs_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Statfs_t Statfs_t_cast(dynamic value)
        {
            return new Statfs_t(value.F_flags, value.F_bsize, value.F_iosize, value.F_blocks, value.F_bfree, value.F_bavail, value.F_files, value.F_ffree, value.F_favail, value.F_syncwrites, value.F_syncreads, value.F_asyncwrites, value.F_asyncreads, value.F_fsid, value.F_namemax, value.F_owner, value.F_ctime, value.F_fstypename, value.F_mntonname, value.F_mntfromname, value.F_mntfromspec, value.Pad_cgo_0, value.Mount_info);
        }
    }
}