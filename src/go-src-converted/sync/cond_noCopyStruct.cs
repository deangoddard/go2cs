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
using atomic = go.sync.atomic_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class sync_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noCopy
        {
            // Constructors
            public noCopy(NilType _)
            {
            }
            // Enable comparisons between nil and noCopy struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noCopy value, NilType nil) => value.Equals(default(noCopy));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noCopy value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noCopy value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noCopy value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noCopy(NilType nil) => default(noCopy);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noCopy noCopy_cast(dynamic value)
        {
            return new noCopy();
        }
    }
}