//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class textproto_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Error
        {
            // Constructors
            public Error(NilType _)
            {
                this.Code = default;
                this.Msg = default;
            }

            public Error(long Code = default, @string Msg = default)
            {
                this.Code = Code;
                this.Msg = Msg;
            }

            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Error Error_cast(dynamic value)
        {
            return new Error(value.Code, value.Msg);
        }
    }
}}