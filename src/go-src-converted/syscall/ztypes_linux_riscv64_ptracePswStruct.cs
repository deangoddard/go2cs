//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ptracePsw
        {
            // Constructors
            public ptracePsw(NilType _)
            {
            }
            // Enable comparisons between nil and ptracePsw struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ptracePsw value, NilType nil) => value.Equals(default(ptracePsw));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ptracePsw value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ptracePsw value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ptracePsw value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ptracePsw(NilType nil) => default(ptracePsw);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ptracePsw ptracePsw_cast(dynamic value)
        {
            return new ptracePsw();
        }
    }
}