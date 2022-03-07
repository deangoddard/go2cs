//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:19:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;

#nullable enable

namespace go
{
    public static partial class testing_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct matcher
        {
            // Constructors
            public matcher(NilType _)
            {
                this.filter = default;
                this.matchFunc = default;
                this.mu = default;
                this.subNames = default;
            }

            public matcher(slice<@string> filter = default, Func<@string, @string, (bool, error)> matchFunc = default, sync.Mutex mu = default, map<@string, long> subNames = default)
            {
                this.filter = filter;
                this.matchFunc = matchFunc;
                this.mu = mu;
                this.subNames = subNames;
            }

            // Enable comparisons between nil and matcher struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(matcher value, NilType nil) => value.Equals(default(matcher));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(matcher value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, matcher value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, matcher value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator matcher(NilType nil) => default(matcher);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static matcher matcher_cast(dynamic value)
        {
            return new matcher(value.filter, value.matchFunc, value.mu, value.subNames);
        }
    }
}