//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:36:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using trace = go.@internal.trace_package;
using log = go.log_package;
using math = go.math_package;
using http = go.net.http_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(trace.UtilWindow))]
        private partial struct linkedUtilWindow
        {
            // UtilWindow structure promotion - sourced from value copy
            private readonly ptr<UtilWindow> m_UtilWindowRef;

            private ref UtilWindow UtilWindow_val => ref m_UtilWindowRef.Value;

            public ref long Time => ref m_UtilWindowRef.Value.Time;

            public ref double MutatorUtil => ref m_UtilWindowRef.Value.MutatorUtil;

            // Constructors
            public linkedUtilWindow(NilType _)
            {
                this.m_UtilWindowRef = new ptr<trace.UtilWindow>(new trace.UtilWindow(nil));
                this.URL = default;
            }

            public linkedUtilWindow(trace.UtilWindow UtilWindow = default, @string URL = default)
            {
                this.m_UtilWindowRef = new ptr<trace.UtilWindow>(UtilWindow);
                this.URL = URL;
            }

            // Enable comparisons between nil and linkedUtilWindow struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(linkedUtilWindow value, NilType nil) => value.Equals(default(linkedUtilWindow));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(linkedUtilWindow value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, linkedUtilWindow value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, linkedUtilWindow value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator linkedUtilWindow(NilType nil) => default(linkedUtilWindow);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static linkedUtilWindow linkedUtilWindow_cast(dynamic value)
        {
            return new linkedUtilWindow(value.UtilWindow, value.URL);
        }
    }
}