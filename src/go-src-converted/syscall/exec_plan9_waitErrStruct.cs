//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:01:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct waitErr
        {
            // Constructors
            public waitErr(NilType _)
            {
                this.Waitmsg = default;
                this.err = default;
            }

            public waitErr(Waitmsg Waitmsg = default, error err = default)
            {
                this.Waitmsg = Waitmsg;
                this.err = err;
            }

            // Enable comparisons between nil and waitErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(waitErr value, NilType nil) => value.Equals(default(waitErr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(waitErr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, waitErr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, waitErr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator waitErr(NilType nil) => default(waitErr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static waitErr waitErr_cast(dynamic value)
        {
            return new waitErr(value.Waitmsg, value.err);
        }
    }
}