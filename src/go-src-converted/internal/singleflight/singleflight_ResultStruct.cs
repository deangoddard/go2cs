//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:52:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class singleflight_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Result
        {
            // Constructors
            public Result(NilType _)
            {
                this.Err = default;
                this.Shared = default;
            }

            public Result(error Err = default, bool Shared = default)
            {
                this.Err = Err;
                this.Shared = Shared;
            }

            // Enable comparisons between nil and Result struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Result value, NilType nil) => value.Equals(default(Result));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Result value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Result value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Result value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Result(NilType nil) => default(Result);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Result Result_cast(dynamic value)
        {
            return new Result(value.Err, value.Shared);
        }
    }
}}