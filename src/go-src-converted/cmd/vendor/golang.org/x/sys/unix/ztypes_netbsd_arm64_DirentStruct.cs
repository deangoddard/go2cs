//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:44 UTC
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
                this.Fileno = default;
                this.Reclen = default;
                this.Namlen = default;
                this.Type = default;
                this.Name = default;
                this.Pad_cgo_0 = default;
            }

            public Dirent(ulong Fileno = default, ushort Reclen = default, ushort Namlen = default, byte Type = default, array<sbyte> Name = default, array<byte> Pad_cgo_0 = default)
            {
                this.Fileno = Fileno;
                this.Reclen = Reclen;
                this.Namlen = Namlen;
                this.Type = Type;
                this.Name = Name;
                this.Pad_cgo_0 = Pad_cgo_0;
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
            return new Dirent(value.Fileno, value.Reclen, value.Namlen, value.Type, value.Name, value.Pad_cgo_0);
        }
    }
}}}}}}