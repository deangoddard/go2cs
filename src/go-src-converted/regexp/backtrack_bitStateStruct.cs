//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:37:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using syntax = go.regexp.syntax_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class regexp_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct bitState
        {
            // Constructors
            public bitState(NilType _)
            {
                this.end = default;
                this.cap = default;
                this.matchcap = default;
                this.jobs = default;
                this.visited = default;
                this.inputs = default;
            }

            public bitState(nint end = default, slice<nint> cap = default, slice<nint> matchcap = default, slice<job> jobs = default, slice<uint> visited = default, inputs inputs = default)
            {
                this.end = end;
                this.cap = cap;
                this.matchcap = matchcap;
                this.jobs = jobs;
                this.visited = visited;
                this.inputs = inputs;
            }

            // Enable comparisons between nil and bitState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitState value, NilType nil) => value.Equals(default(bitState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitState(NilType nil) => default(bitState);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static bitState bitState_cast(dynamic value)
        {
            return new bitState(value.end, value.cap, value.matchcap, value.jobs, value.visited, value.inputs);
        }
    }
}