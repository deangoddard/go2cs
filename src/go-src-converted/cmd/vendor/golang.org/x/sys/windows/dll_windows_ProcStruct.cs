//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
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
        public partial struct Proc
        {
            // Constructors
            public Proc(NilType _)
            {
                this.Dll = default;
                this.Name = default;
                this.addr = default;
            }

            public Proc(ref ptr<DLL> Dll = default, @string Name = default, System.UIntPtr addr = default)
            {
                this.Dll = Dll;
                this.Name = Name;
                this.addr = addr;
            }

            // Enable comparisons between nil and Proc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Proc value, NilType nil) => value.Equals(default(Proc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Proc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Proc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Proc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Proc(NilType nil) => default(Proc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Proc Proc_cast(dynamic value)
        {
            return new Proc(ref value.Dll, value.Name, value.addr);
        }
    }
}}}}}}