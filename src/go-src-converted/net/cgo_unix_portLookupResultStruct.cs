//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:15:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using C = go.C_package;
using context = go.context_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct portLookupResult
        {
            // Constructors
            public portLookupResult(NilType _)
            {
                this.port = default;
                this.err = default;
            }

            public portLookupResult(nint port = default, error err = default)
            {
                this.port = port;
                this.err = err;
            }

            // Enable comparisons between nil and portLookupResult struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(portLookupResult value, NilType nil) => value.Equals(default(portLookupResult));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(portLookupResult value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, portLookupResult value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, portLookupResult value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator portLookupResult(NilType nil) => default(portLookupResult);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static portLookupResult portLookupResult_cast(dynamic value)
        {
            return new portLookupResult(value.port, value.err);
        }
    }
}