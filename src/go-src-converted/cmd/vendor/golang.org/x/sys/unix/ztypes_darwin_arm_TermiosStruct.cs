//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:29 UTC
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
        public partial struct Termios
        {
            // Constructors
            public Termios(NilType _)
            {
                this.Iflag = default;
                this.Oflag = default;
                this.Cflag = default;
                this.Lflag = default;
                this.Cc = default;
                this.Ispeed = default;
                this.Ospeed = default;
            }

            public Termios(uint Iflag = default, uint Oflag = default, uint Cflag = default, uint Lflag = default, array<byte> Cc = default, uint Ispeed = default, uint Ospeed = default)
            {
                this.Iflag = Iflag;
                this.Oflag = Oflag;
                this.Cflag = Cflag;
                this.Lflag = Lflag;
                this.Cc = Cc;
                this.Ispeed = Ispeed;
                this.Ospeed = Ospeed;
            }

            // Enable comparisons between nil and Termios struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Termios value, NilType nil) => value.Equals(default(Termios));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Termios value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Termios value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Termios value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Termios(NilType nil) => default(Termios);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Termios Termios_cast(dynamic value)
        {
            return new Termios(value.Iflag, value.Oflag, value.Cflag, value.Lflag, value.Cc, value.Ispeed, value.Ospeed);
        }
    }
}}}}}}