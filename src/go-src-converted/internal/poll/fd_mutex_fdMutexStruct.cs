//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:13:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using atomic = go.sync.atomic_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class poll_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fdMutex
        {
            // Constructors
            public fdMutex(NilType _)
            {
                this.state = default;
                this.rsema = default;
                this.wsema = default;
            }

            public fdMutex(ulong state = default, uint rsema = default, uint wsema = default)
            {
                this.state = state;
                this.rsema = rsema;
                this.wsema = wsema;
            }

            // Enable comparisons between nil and fdMutex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fdMutex value, NilType nil) => value.Equals(default(fdMutex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fdMutex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fdMutex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fdMutex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fdMutex(NilType nil) => default(fdMutex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fdMutex fdMutex_cast(dynamic value)
        {
            return new fdMutex(value.state, value.rsema, value.wsema);
        }
    }
}}