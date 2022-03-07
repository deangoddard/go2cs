//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:51 UTC
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
        public partial struct Dirent
        {
            // Constructors
            public Dirent(NilType _)
            {
                this.Fileno = default;
                this.Off = default;
                this.Reclen = default;
                this.Type = default;
                this.Namlen = default;
                this.X__d_padding = default;
                this.Name = default;
            }

            public Dirent(ulong Fileno = default, long Off = default, ushort Reclen = default, byte Type = default, byte Namlen = default, array<byte> X__d_padding = default, array<sbyte> Name = default)
            {
                this.Fileno = Fileno;
                this.Off = Off;
                this.Reclen = Reclen;
                this.Type = Type;
                this.Namlen = Namlen;
                this.X__d_padding = X__d_padding;
                this.Name = Name;
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
            return new Dirent(value.Fileno, value.Off, value.Reclen, value.Type, value.Namlen, value.X__d_padding, value.Name);
        }
    }
}