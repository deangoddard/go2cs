//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:52:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using syscall = go.syscall_package;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(rawConn))]
        private partial struct rawListener
        {
            // rawConn structure promotion - sourced from value copy
            private readonly ptr<rawConn> m_rawConnRef;

            private ref rawConn rawConn_val => ref m_rawConnRef.Value;

            public ref ptr<netFD> fd => ref m_rawConnRef.Value.fd;

            // Constructors
            public rawListener(NilType _)
            {
                this.m_rawConnRef = new ptr<rawConn>(new rawConn(nil));
            }

            public rawListener(rawConn rawConn = default)
            {
                this.m_rawConnRef = new ptr<rawConn>(rawConn);
            }

            // Enable comparisons between nil and rawListener struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(rawListener value, NilType nil) => value.Equals(default(rawListener));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(rawListener value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, rawListener value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, rawListener value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator rawListener(NilType nil) => default(rawListener);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static rawListener rawListener_cast(dynamic value)
        {
            return new rawListener(value.rawConn);
        }
    }
}