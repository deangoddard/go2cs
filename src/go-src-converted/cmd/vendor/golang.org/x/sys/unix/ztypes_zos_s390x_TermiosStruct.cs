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
        public partial struct Termios
        {
            // Constructors
            public Termios(NilType _)
            {
                this.Cflag = default;
                this.Iflag = default;
                this.Lflag = default;
                this.Oflag = default;
                this.Cc = default;
            }

            public Termios(uint Cflag = default, uint Iflag = default, uint Lflag = default, uint Oflag = default, array<byte> Cc = default)
            {
                this.Cflag = Cflag;
                this.Iflag = Iflag;
                this.Lflag = Lflag;
                this.Oflag = Oflag;
                this.Cc = Cc;
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
            return new Termios(value.Cflag, value.Iflag, value.Lflag, value.Oflag, value.Cc);
        }
    }
}}}}}}