//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:31:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using runtime = go.runtime_package;
using plan9 = go.golang.org.x.sys.plan9_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x
{
    public static partial class term_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct state
        {
            // Constructors
            public state(NilType _)
            {
            }
            // Enable comparisons between nil and state struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(state value, NilType nil) => value.Equals(default(state));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(state value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, state value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, state value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator state(NilType nil) => default(state);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static state state_cast(dynamic value)
        {
            return new state();
        }
    }
}}}}}