//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InitSchedule
        {
            // Constructors
            public InitSchedule(NilType _)
            {
                this.@out = default;
                this.initplans = default;
                this.inittemps = default;
            }

            public InitSchedule(slice<ptr<Node>> @out = default, map<ptr<Node>, ptr<InitPlan>> initplans = default, map<ptr<Node>, ptr<Node>> inittemps = default)
            {
                this.@out = @out;
                this.initplans = initplans;
                this.inittemps = inittemps;
            }

            // Enable comparisons between nil and InitSchedule struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InitSchedule value, NilType nil) => value.Equals(default(InitSchedule));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InitSchedule value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InitSchedule value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InitSchedule value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InitSchedule(NilType nil) => default(InitSchedule);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InitSchedule InitSchedule_cast(dynamic value)
        {
            return new InitSchedule(value.@out, value.initplans, value.inittemps);
        }
    }
}}}}