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
        public partial struct OPTResource
        {
            // Constructors
            public OPTResource(NilType _)
            {
                this.Options = default;
            }

            public OPTResource(slice<Option> Options = default)
            {
                this.Options = Options;
            }

            // Enable comparisons between nil and OPTResource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OPTResource value, NilType nil) => value.Equals(default(OPTResource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OPTResource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OPTResource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OPTResource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator OPTResource(NilType nil) => default(OPTResource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static OPTResource OPTResource_cast(dynamic value)
        {
            return new OPTResource(value.Options);
        }
    }
}}}}}}