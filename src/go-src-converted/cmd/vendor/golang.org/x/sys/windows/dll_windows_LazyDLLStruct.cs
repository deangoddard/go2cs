//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:30:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct LazyDLL
        {
            // Constructors
            public LazyDLL(NilType _)
            {
                this.Name = default;
                this.System = default;
                this.mu = default;
                this.dll = default;
            }

            public LazyDLL(@string Name = default, bool System = default, sync.Mutex mu = default, ref ptr<DLL> dll = default)
            {
                this.Name = Name;
                this.System = System;
                this.mu = mu;
                this.dll = dll;
            }

            // Enable comparisons between nil and LazyDLL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LazyDLL value, NilType nil) => value.Equals(default(LazyDLL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LazyDLL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LazyDLL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LazyDLL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LazyDLL(NilType nil) => default(LazyDLL);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LazyDLL LazyDLL_cast(dynamic value)
        {
            return new LazyDLL(value.Name, value.System, value.mu, ref value.dll);
        }
    }
}}}}}}