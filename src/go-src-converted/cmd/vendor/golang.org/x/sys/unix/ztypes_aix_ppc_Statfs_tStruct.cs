//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:28 UTC
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
        public partial struct Statfs_t
        {
            // Constructors
            public Statfs_t(NilType _)
            {
                this.Version = default;
                this.Type = default;
                this.Bsize = default;
                this.Blocks = default;
                this.Bfree = default;
                this.Bavail = default;
                this.Files = default;
                this.Ffree = default;
                this.Fsid = default;
                this.Vfstype = default;
                this.Fsize = default;
                this.Vfsnumber = default;
                this.Vfsoff = default;
                this.Vfslen = default;
                this.Vfsvers = default;
                this.Fname = default;
                this.Fpack = default;
                this.Name_max = default;
            }

            public Statfs_t(int Version = default, int Type = default, uint Bsize = default, uint Blocks = default, uint Bfree = default, uint Bavail = default, uint Files = default, uint Ffree = default, Fsid_t Fsid = default, int Vfstype = default, uint Fsize = default, int Vfsnumber = default, int Vfsoff = default, int Vfslen = default, int Vfsvers = default, array<byte> Fname = default, array<byte> Fpack = default, int Name_max = default)
            {
                this.Version = Version;
                this.Type = Type;
                this.Bsize = Bsize;
                this.Blocks = Blocks;
                this.Bfree = Bfree;
                this.Bavail = Bavail;
                this.Files = Files;
                this.Ffree = Ffree;
                this.Fsid = Fsid;
                this.Vfstype = Vfstype;
                this.Fsize = Fsize;
                this.Vfsnumber = Vfsnumber;
                this.Vfsoff = Vfsoff;
                this.Vfslen = Vfslen;
                this.Vfsvers = Vfsvers;
                this.Fname = Fname;
                this.Fpack = Fpack;
                this.Name_max = Name_max;
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
            return new Statfs_t(value.Version, value.Type, value.Bsize, value.Blocks, value.Bfree, value.Bavail, value.Files, value.Ffree, value.Fsid, value.Vfstype, value.Fsize, value.Vfsnumber, value.Vfsoff, value.Vfslen, value.Vfsvers, value.Fname, value.Fpack, value.Name_max);
        }
    }
}}}}}}