//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.go.types_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace types
{
    public static partial class typeutil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct MethodSetCache
        {
            // Constructors
            public MethodSetCache(NilType _)
            {
                this.mu = default;
                this.others = default;
            }

            public MethodSetCache(sync.Mutex mu = default, map<types.Type, ptr<types.MethodSet>> others = default)
            {
                this.mu = mu;
                this.others = others;
            }

            // Enable comparisons between nil and MethodSetCache struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MethodSetCache value, NilType nil) => value.Equals(default(MethodSetCache));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MethodSetCache value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MethodSetCache value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MethodSetCache value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MethodSetCache(NilType nil) => default(MethodSetCache);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MethodSetCache MethodSetCache_cast(dynamic value)
        {
            return new MethodSetCache(value.mu, value.others);
        }
    }
}}}}}}