//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:37:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        public partial struct Resource
        {
            // Constructors
            public Resource(NilType _)
            {
                this.Header = default;
                this.Body = default;
            }

            public Resource(ResourceHeader Header = default, ResourceBody Body = default)
            {
                this.Header = Header;
                this.Body = Body;
            }

            // Enable comparisons between nil and Resource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Resource value, NilType nil) => value.Equals(default(Resource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Resource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Resource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Resource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Resource(NilType nil) => default(Resource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Resource Resource_cast(dynamic value)
        {
            return new Resource(value.Header, value.Body);
        }
    }
}}}}}}