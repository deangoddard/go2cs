//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:29 UTC
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
        public partial struct Dirent
        {
            // Constructors
            public Dirent(NilType _)
            {
                this.Ino = default;
                this.Off = default;
                this.Reclen = default;
                this.Type = default;
                this.Name = default;
                this._ = default;
            }

            public Dirent(ulong Ino = default, long Off = default, ushort Reclen = default, byte Type = default, array<sbyte> Name = default, array<byte> _ = default)
            {
                this.Ino = Ino;
                this.Off = Off;
                this.Reclen = Reclen;
                this.Type = Type;
                this.Name = Name;
                this._ = _;
            }

            // Enable comparisons between nil and Dirent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dirent value, NilType nil) => value.Equals(default(Dirent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dirent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dirent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dirent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dirent(NilType nil) => default(Dirent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Dirent Dirent_cast(dynamic value)
        {
            return new Dirent(value.Ino, value.Off, value.Reclen, value.Type, value.Name, value._);
        }
    }
}}}}}}