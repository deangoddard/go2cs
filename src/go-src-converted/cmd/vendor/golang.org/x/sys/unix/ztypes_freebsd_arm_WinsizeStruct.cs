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
        public partial struct Winsize
        {
            // Constructors
            public Winsize(NilType _)
            {
                this.Row = default;
                this.Col = default;
                this.Xpixel = default;
                this.Ypixel = default;
            }

            public Winsize(ushort Row = default, ushort Col = default, ushort Xpixel = default, ushort Ypixel = default)
            {
                this.Row = Row;
                this.Col = Col;
                this.Xpixel = Xpixel;
                this.Ypixel = Ypixel;
            }

            // Enable comparisons between nil and Winsize struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Winsize value, NilType nil) => value.Equals(default(Winsize));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Winsize value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Winsize value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Winsize value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Winsize(NilType nil) => default(Winsize);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Winsize Winsize_cast(dynamic value)
        {
            return new Winsize(value.Row, value.Col, value.Xpixel, value.Ypixel);
        }
    }
}}}}}}