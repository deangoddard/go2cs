//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:27:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using io = go.io_package;
using sync = go.sync_package;
using time = go.time_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pipeDeadline
        {
            // Constructors
            public pipeDeadline(NilType _)
            {
                this.mu = default;
                this.timer = default;
                this.cancel = default;
            }

            public pipeDeadline(sync.Mutex mu = default, ref ptr<time.Timer> timer = default, channel<object> cancel = default)
            {
                this.mu = mu;
                this.timer = timer;
                this.cancel = cancel;
            }

            // Enable comparisons between nil and pipeDeadline struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pipeDeadline value, NilType nil) => value.Equals(default(pipeDeadline));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pipeDeadline value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pipeDeadline value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pipeDeadline value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pipeDeadline(NilType nil) => default(pipeDeadline);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pipeDeadline pipeDeadline_cast(dynamic value)
        {
            return new pipeDeadline(value.mu, ref value.timer, value.cancel);
        }
    }
}