//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:35:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct gState
        {
            // Constructors
            public gState(NilType _)
            {
                this.seq = default;
                this.status = default;
            }

            public gState(ulong seq = default, gStatus status = default)
            {
                this.seq = seq;
                this.status = status;
            }

            // Enable comparisons between nil and gState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gState value, NilType nil) => value.Equals(default(gState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gState(NilType nil) => default(gState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static gState gState_cast(dynamic value)
        {
            return new gState(value.seq, value.status);
        }
    }
}}