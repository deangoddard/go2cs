//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:27:01 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using binary = go.encoding.binary_package;
using runtime = go.runtime_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
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
        public partial struct SockaddrIUCV
        {
            // Constructors
            public SockaddrIUCV(NilType _)
            {
                this.UserID = default;
                this.Name = default;
                this.raw = default;
            }

            public SockaddrIUCV(@string UserID = default, @string Name = default, RawSockaddrIUCV raw = default)
            {
                this.UserID = UserID;
                this.Name = Name;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrIUCV struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrIUCV value, NilType nil) => value.Equals(default(SockaddrIUCV));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrIUCV value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrIUCV value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrIUCV value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrIUCV(NilType nil) => default(SockaddrIUCV);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrIUCV SockaddrIUCV_cast(dynamic value)
        {
            return new SockaddrIUCV(value.UserID, value.Name, value.raw);
        }
    }
}}}}}}