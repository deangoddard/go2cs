//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct PTRResource
        {
            // Constructors
            public PTRResource(NilType _)
            {
                this.PTR = default;
            }

            public PTRResource(Name PTR = default)
            {
                this.PTR = PTR;
            }

            // Enable comparisons between nil and PTRResource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PTRResource value, NilType nil) => value.Equals(default(PTRResource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PTRResource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PTRResource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PTRResource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PTRResource(NilType nil) => default(PTRResource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static PTRResource PTRResource_cast(dynamic value)
        {
            return new PTRResource(value.PTR);
        }
    }
}}}}}}