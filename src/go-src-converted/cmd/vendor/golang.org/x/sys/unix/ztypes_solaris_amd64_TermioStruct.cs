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
        public partial struct Termio
        {
            // Constructors
            public Termio(NilType _)
            {
                this.Iflag = default;
                this.Oflag = default;
                this.Cflag = default;
                this.Lflag = default;
                this.Line = default;
                this.Cc = default;
                this._ = default;
            }

            public Termio(ushort Iflag = default, ushort Oflag = default, ushort Cflag = default, ushort Lflag = default, sbyte Line = default, array<byte> Cc = default, array<byte> _ = default)
            {
                this.Iflag = Iflag;
                this.Oflag = Oflag;
                this.Cflag = Cflag;
                this.Lflag = Lflag;
                this.Line = Line;
                this.Cc = Cc;
                this._ = _;
            }

            // Enable comparisons between nil and Termio struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Termio value, NilType nil) => value.Equals(default(Termio));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Termio value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Termio value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Termio value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Termio(NilType nil) => default(Termio);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Termio Termio_cast(dynamic value)
        {
            return new Termio(value.Iflag, value.Oflag, value.Cflag, value.Lflag, value.Line, value.Cc, value._);
        }
    }
}}}}}}