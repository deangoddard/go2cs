//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:47 UTC
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
        public partial struct Name
        {
            // Constructors
            public Name(NilType _)
            {
                this.Data = default;
                this.Length = default;
            }

            public Name(array<byte> Data = default, byte Length = default)
            {
                this.Data = Data;
                this.Length = Length;
            }

            // Enable comparisons between nil and Name struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Name value, NilType nil) => value.Equals(default(Name));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Name value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Name value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Name value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Name(NilType nil) => default(Name);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Name Name_cast(dynamic value)
        {
            return new Name(value.Data, value.Length);
        }
    }
}}}}}}