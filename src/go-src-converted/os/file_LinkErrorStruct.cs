//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using poll = go.@internal.poll_package;
using testlog = go.@internal.testlog_package;
using io = go.io_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class os_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LinkError
        {
            // Constructors
            public LinkError(NilType _)
            {
                this.Op = default;
                this.Old = default;
                this.New = default;
                this.Err = default;
            }

            public LinkError(@string Op = default, @string Old = default, @string New = default, error Err = default)
            {
                this.Op = Op;
                this.Old = Old;
                this.New = New;
                this.Err = Err;
            }

            // Enable comparisons between nil and LinkError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LinkError value, NilType nil) => value.Equals(default(LinkError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LinkError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LinkError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LinkError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LinkError(NilType nil) => default(LinkError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LinkError LinkError_cast(dynamic value)
        {
            return new LinkError(value.Op, value.Old, value.New, value.Err);
        }
    }
}