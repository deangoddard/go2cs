//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrStorage
        {
            // Constructors
            public SockaddrStorage(NilType _)
            {
                this.Family = default;
                this._ = default;
                this._ = default;
            }

            public SockaddrStorage(ushort Family = default, array<byte> _ = default, ulong _ = default)
            {
                this.Family = Family;
                this._ = _;
                this._ = _;
            }

            // Enable comparisons between nil and SockaddrStorage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrStorage value, NilType nil) => value.Equals(default(SockaddrStorage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrStorage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrStorage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrStorage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrStorage(NilType nil) => default(SockaddrStorage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrStorage SockaddrStorage_cast(dynamic value)
        {
            return new SockaddrStorage(value.Family, value._, value._);
        }
    }
}}}}}}