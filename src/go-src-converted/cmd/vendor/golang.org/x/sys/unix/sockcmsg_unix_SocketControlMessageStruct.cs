//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:41:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct SocketControlMessage
        {
            // Constructors
            public SocketControlMessage(NilType _)
            {
                this.Header = default;
                this.Data = default;
            }

            public SocketControlMessage(Cmsghdr Header = default, slice<byte> Data = default)
            {
                this.Header = Header;
                this.Data = Data;
            }

            // Enable comparisons between nil and SocketControlMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SocketControlMessage value, NilType nil) => value.Equals(default(SocketControlMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SocketControlMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SocketControlMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SocketControlMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SocketControlMessage(NilType nil) => default(SocketControlMessage);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static SocketControlMessage SocketControlMessage_cast(dynamic value)
        {
            return new SocketControlMessage(value.Header, value.Data);
        }
    }
}}}}}}