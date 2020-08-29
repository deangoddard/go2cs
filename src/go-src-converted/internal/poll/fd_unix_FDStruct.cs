//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:25:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using go;

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FD
        {
            // Constructors
            public FD(NilType _)
            {
                this.fdmu = default;
                this.Sysfd = default;
                this.pd = default;
                this.iovecs = default;
                this.csema = default;
                this.IsStream = default;
                this.ZeroReadIsEOF = default;
                this.isFile = default;
                this.isBlocking = default;
            }

            public FD(fdMutex fdmu = default, long Sysfd = default, pollDesc pd = default, ref ptr<slice<syscall.Iovec>> iovecs = default, uint csema = default, bool IsStream = default, bool ZeroReadIsEOF = default, bool isFile = default, bool isBlocking = default)
            {
                this.fdmu = fdmu;
                this.Sysfd = Sysfd;
                this.pd = pd;
                this.iovecs = iovecs;
                this.csema = csema;
                this.IsStream = IsStream;
                this.ZeroReadIsEOF = ZeroReadIsEOF;
                this.isFile = isFile;
                this.isBlocking = isBlocking;
            }

            // Enable comparisons between nil and FD struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FD value, NilType nil) => value.Equals(default(FD));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FD value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FD value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FD value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FD(NilType nil) => default(FD);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FD FD_cast(dynamic value)
        {
            return new FD(value.fdmu, value.Sysfd, value.pd, ref value.iovecs, value.csema, value.IsStream, value.ZeroReadIsEOF, value.isFile, value.isBlocking);
        }
    }
}}