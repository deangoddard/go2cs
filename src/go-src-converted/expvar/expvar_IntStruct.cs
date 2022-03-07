//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using log = go.log_package;
using math = go.math_package;
using http = go.net.http_package;
using os = go.os_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;

#nullable enable

namespace go
{
    public static partial class expvar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Int
        {
            // Constructors
            public Int(NilType _)
            {
                this.i = default;
            }

            public Int(long i = default)
            {
                this.i = i;
            }

            // Enable comparisons between nil and Int struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Int value, NilType nil) => value.Equals(default(Int));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Int value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Int value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Int value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Int(NilType nil) => default(Int);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Int Int_cast(dynamic value)
        {
            return new Int(value.i);
        }
    }
}