//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:26:32 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct eventPoll
        {
            // Constructors
            public eventPoll(NilType _)
            {
                this.mu = default;
                this.fds = default;
            }

            public eventPoll(sync.Mutex mu = default, map<nint, ptr<EpollEvent>> fds = default)
            {
                this.mu = mu;
                this.fds = fds;
            }

            // Enable comparisons between nil and eventPoll struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(eventPoll value, NilType nil) => value.Equals(default(eventPoll));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(eventPoll value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, eventPoll value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, eventPoll value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator eventPoll(NilType nil) => default(eventPoll);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static eventPoll eventPoll_cast(dynamic value)
        {
            return new eventPoll(value.mu, value.fds);
        }
    }
}}}}}}