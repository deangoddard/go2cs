//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmtsort = go.@internal.fmtsort_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;

#nullable enable

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pp
        {
            // Constructors
            public pp(NilType _)
            {
                this.buf = default;
                this.value = default;
                this.fmt = default;
                this.reordered = default;
                this.goodArgNum = default;
                this.panicking = default;
                this.erroring = default;
                this.wrapErrs = default;
                this.wrappedErr = default;
            }

            public pp(buffer buf = default, reflect.Value value = default, fmt fmt = default, bool reordered = default, bool goodArgNum = default, bool panicking = default, bool erroring = default, bool wrapErrs = default, error wrappedErr = default)
            {
                this.buf = buf;
                this.value = value;
                this.fmt = fmt;
                this.reordered = reordered;
                this.goodArgNum = goodArgNum;
                this.panicking = panicking;
                this.erroring = erroring;
                this.wrapErrs = wrapErrs;
                this.wrappedErr = wrappedErr;
            }

            // Enable comparisons between nil and pp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pp value, NilType nil) => value.Equals(default(pp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pp(NilType nil) => default(pp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pp pp_cast(dynamic value)
        {
            return new pp(value.buf, value.value, value.fmt, value.reordered, value.goodArgNum, value.panicking, value.erroring, value.wrapErrs, value.wrappedErr);
        }
    }
}