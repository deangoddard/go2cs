//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:08:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typeCacheBucket
        {
            // Constructors
            public typeCacheBucket(NilType _)
            {
                this.t = default;
            }

            public typeCacheBucket(array<ptr<_type>> t = default)
            {
                this.t = t;
            }

            // Enable comparisons between nil and typeCacheBucket struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeCacheBucket value, NilType nil) => value.Equals(default(typeCacheBucket));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeCacheBucket value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeCacheBucket value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeCacheBucket value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeCacheBucket(NilType nil) => default(typeCacheBucket);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typeCacheBucket typeCacheBucket_cast(dynamic value)
        {
            return new typeCacheBucket(value.t);
        }
    }
}