//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:45:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
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
        public partial struct DLL
        {
            // Constructors
            public DLL(NilType _)
            {
                this.Name = default;
                this.Handle = default;
            }

            public DLL(@string Name = default, Handle Handle = default)
            {
                this.Name = Name;
                this.Handle = Handle;
            }

            // Enable comparisons between nil and DLL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(DLL value, NilType nil) => value.Equals(default(DLL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(DLL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, DLL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, DLL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator DLL(NilType nil) => default(DLL);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static DLL DLL_cast(dynamic value)
        {
            return new DLL(value.Name, value.Handle);
        }
    }
}