//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:49:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using reflectlite = go.@internal.reflectlite_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class context_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct deadlineExceededError
        {
            // Constructors
            public deadlineExceededError(NilType _)
            {
            }
            // Enable comparisons between nil and deadlineExceededError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(deadlineExceededError value, NilType nil) => value.Equals(default(deadlineExceededError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(deadlineExceededError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, deadlineExceededError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, deadlineExceededError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator deadlineExceededError(NilType nil) => default(deadlineExceededError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static deadlineExceededError deadlineExceededError_cast(dynamic value)
        {
            return new deadlineExceededError();
        }
    }
}