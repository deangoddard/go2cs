//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using itoa = go.@internal.itoa_package;
using sysdll = go.@internal.syscall.windows.sysdll_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LazyDLL
        {
            // Constructors
            public LazyDLL(NilType _)
            {
                this.mu = default;
                this.dll = default;
                this.Name = default;
            }

            public LazyDLL(sync.Mutex mu = default, ref ptr<DLL> dll = default, @string Name = default)
            {
                this.mu = mu;
                this.dll = dll;
                this.Name = Name;
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
            return new LazyDLL(value.mu, ref value.dll, value.Name);
        }
    }
}