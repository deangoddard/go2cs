//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ConsoleScreenBufferInfo
        {
            // Constructors
            public ConsoleScreenBufferInfo(NilType _)
            {
                this.Size = default;
                this.CursorPosition = default;
                this.Attributes = default;
                this.Window = default;
                this.MaximumWindowSize = default;
            }

            public ConsoleScreenBufferInfo(Coord Size = default, Coord CursorPosition = default, ushort Attributes = default, SmallRect Window = default, Coord MaximumWindowSize = default)
            {
                this.Size = Size;
                this.CursorPosition = CursorPosition;
                this.Attributes = Attributes;
                this.Window = Window;
                this.MaximumWindowSize = MaximumWindowSize;
            }

            // Enable comparisons between nil and ConsoleScreenBufferInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ConsoleScreenBufferInfo value, NilType nil) => value.Equals(default(ConsoleScreenBufferInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ConsoleScreenBufferInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ConsoleScreenBufferInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ConsoleScreenBufferInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ConsoleScreenBufferInfo(NilType nil) => default(ConsoleScreenBufferInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ConsoleScreenBufferInfo ConsoleScreenBufferInfo_cast(dynamic value)
        {
            return new ConsoleScreenBufferInfo(value.Size, value.CursorPosition, value.Attributes, value.Window, value.MaximumWindowSize);
        }
    }
}}}}}}