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
        private partial struct __Siginfo
        {
            // Constructors
            public __Siginfo(NilType _)
            {
                this.Signo = default;
                this.Errno = default;
                this.Code = default;
                this.Pid = default;
                this.Uid = default;
                this.Status = default;
                this.Addr = default;
                this.Value = default;
                this._ = default;
            }

            public __Siginfo(int Signo = default, int Errno = default, int Code = default, int Pid = default, uint Uid = default, int Status = default, ref ptr<byte> Addr = default, array<byte> Value = default, array<byte> _ = default)
            {
                this.Signo = Signo;
                this.Errno = Errno;
                this.Code = Code;
                this.Pid = Pid;
                this.Uid = Uid;
                this.Status = Status;
                this.Addr = Addr;
                this.Value = Value;
                this._ = _;
            }

            // Enable comparisons between nil and __Siginfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(__Siginfo value, NilType nil) => value.Equals(default(__Siginfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(__Siginfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, __Siginfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, __Siginfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator __Siginfo(NilType nil) => default(__Siginfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static __Siginfo __Siginfo_cast(dynamic value)
        {
            return new __Siginfo(value.Signo, value.Errno, value.Code, value.Pid, value.Uid, value.Status, ref value.Addr, value.Value, value._);
        }
    }
}}}}}}