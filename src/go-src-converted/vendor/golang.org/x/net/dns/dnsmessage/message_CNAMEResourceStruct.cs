//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:45:25 UTC
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct CNAMEResource
        {
            // Constructors
            public CNAMEResource(NilType _)
            {
                this.CNAME = default;
            }

            public CNAMEResource(Name CNAME = default)
            {
                this.CNAME = CNAME;
            }

            // Enable comparisons between nil and CNAMEResource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CNAMEResource value, NilType nil) => value.Equals(default(CNAMEResource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CNAMEResource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CNAMEResource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CNAMEResource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CNAMEResource(NilType nil) => default(CNAMEResource);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static CNAMEResource CNAMEResource_cast(dynamic value)
        {
            return new CNAMEResource(value.CNAME);
        }
    }
}}}}}}