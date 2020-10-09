//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:08:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct scanError
        {
            // Constructors
            public scanError(NilType _)
            {
                this.err = default;
            }

            public scanError(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and scanError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(scanError value, NilType nil) => value.Equals(default(scanError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(scanError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, scanError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, scanError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator scanError(NilType nil) => default(scanError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static scanError scanError_cast(dynamic value)
        {
            return new scanError(value.err);
        }
    }
}