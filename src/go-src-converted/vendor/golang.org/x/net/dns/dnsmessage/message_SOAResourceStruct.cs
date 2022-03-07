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
        public partial struct SOAResource
        {
            // Constructors
            public SOAResource(NilType _)
            {
                this.NS = default;
                this.MBox = default;
                this.Serial = default;
                this.Refresh = default;
                this.Retry = default;
                this.Expire = default;
                this.MinTTL = default;
            }

            public SOAResource(Name NS = default, Name MBox = default, uint Serial = default, uint Refresh = default, uint Retry = default, uint Expire = default, uint MinTTL = default)
            {
                this.NS = NS;
                this.MBox = MBox;
                this.Serial = Serial;
                this.Refresh = Refresh;
                this.Retry = Retry;
                this.Expire = Expire;
                this.MinTTL = MinTTL;
            }

            // Enable comparisons between nil and SOAResource struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SOAResource value, NilType nil) => value.Equals(default(SOAResource));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SOAResource value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SOAResource value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SOAResource value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SOAResource(NilType nil) => default(SOAResource);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SOAResource SOAResource_cast(dynamic value)
        {
            return new SOAResource(value.NS, value.MBox, value.Serial, value.Refresh, value.Retry, value.Expire, value.MinTTL);
        }
    }
}}}}}}