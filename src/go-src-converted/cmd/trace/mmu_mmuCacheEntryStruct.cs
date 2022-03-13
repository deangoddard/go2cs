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
        private partial struct mmuCacheEntry
        {
            // Constructors
            public mmuCacheEntry(NilType _)
            {
                this.init = default;
                this.util = default;
                this.mmuCurve = default;
                this.err = default;
            }

            public mmuCacheEntry(sync.Once init = default, slice<slice<trace.MutatorUtil>> util = default, ref ptr<trace.MMUCurve> mmuCurve = default, error err = default)
            {
                this.init = init;
                this.util = util;
                this.mmuCurve = mmuCurve;
                this.err = err;
            }

            // Enable comparisons between nil and mmuCacheEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mmuCacheEntry value, NilType nil) => value.Equals(default(mmuCacheEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mmuCacheEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mmuCacheEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mmuCacheEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mmuCacheEntry(NilType nil) => default(mmuCacheEntry);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static mmuCacheEntry mmuCacheEntry_cast(dynamic value)
        {
            return new mmuCacheEntry(value.init, value.util, ref value.mmuCurve, value.err);
        }
    }
}