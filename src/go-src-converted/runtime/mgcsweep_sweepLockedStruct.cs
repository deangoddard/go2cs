//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:25:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.runtime.@internal.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct sweepLocked
        {
            // Constructors
            public sweepLocked(NilType _)
            {
                this.ptr<mspan> = default;
            }

            public sweepLocked(ref ptr<mspan> ptr<mspan> = default)
            {
                this.ptr<mspan> = ptr<mspan>;
            }

            // Enable comparisons between nil and sweepLocked struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sweepLocked value, NilType nil) => value.Equals(default(sweepLocked));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sweepLocked value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sweepLocked value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sweepLocked value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sweepLocked(NilType nil) => default(sweepLocked);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static sweepLocked sweepLocked_cast(dynamic value)
        {
            return new sweepLocked(ref value.ptr<mspan>);
        }
    }
}