//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:31 UTC
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
        public partial struct PtraceLwpInfoStruct
        {
            // Constructors
            public PtraceLwpInfoStruct(NilType _)
            {
                this.Lwpid = default;
                this.Event = default;
                this.Flags = default;
                this.Sigmask = default;
                this.Siglist = default;
                this.Siginfo = default;
                this.Tdname = default;
                this.Child_pid = default;
                this.Syscall_code = default;
                this.Syscall_narg = default;
            }

            public PtraceLwpInfoStruct(int Lwpid = default, int Event = default, int Flags = default, Sigset_t Sigmask = default, Sigset_t Siglist = default, __Siginfo Siginfo = default, array<sbyte> Tdname = default, int Child_pid = default, uint Syscall_code = default, uint Syscall_narg = default)
            {
                this.Lwpid = Lwpid;
                this.Event = Event;
                this.Flags = Flags;
                this.Sigmask = Sigmask;
                this.Siglist = Siglist;
                this.Siginfo = Siginfo;
                this.Tdname = Tdname;
                this.Child_pid = Child_pid;
                this.Syscall_code = Syscall_code;
                this.Syscall_narg = Syscall_narg;
            }

            // Enable comparisons between nil and PtraceLwpInfoStruct struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PtraceLwpInfoStruct value, NilType nil) => value.Equals(default(PtraceLwpInfoStruct));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PtraceLwpInfoStruct value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PtraceLwpInfoStruct value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PtraceLwpInfoStruct value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PtraceLwpInfoStruct(NilType nil) => default(PtraceLwpInfoStruct);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PtraceLwpInfoStruct PtraceLwpInfoStruct_cast(dynamic value)
        {
            return new PtraceLwpInfoStruct(value.Lwpid, value.Event, value.Flags, value.Sigmask, value.Siglist, value.Siginfo, value.Tdname, value.Child_pid, value.Syscall_code, value.Syscall_narg);
        }
    }
}}}}}}