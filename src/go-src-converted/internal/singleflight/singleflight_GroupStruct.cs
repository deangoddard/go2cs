//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:16:17 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class singleflight_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Group
        {
            // Constructors
            public Group(NilType _)
            {
                this.mu = default;
                this.m = default;
            }

            public Group(sync.Mutex mu = default, map<@string, ptr<call>> m = default)
            {
                this.mu = mu;
                this.m = m;
            }

            // Enable comparisons between nil and Group struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Group value, NilType nil) => value.Equals(default(Group));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Group value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Group value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Group value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Group(NilType nil) => default(Group);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Group Group_cast(dynamic value)
        {
            return new Group(value.mu, value.m);
        }
    }
}}