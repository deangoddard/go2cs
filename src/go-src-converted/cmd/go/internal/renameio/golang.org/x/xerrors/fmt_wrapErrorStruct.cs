//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:45:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @internal = go.golang.org.x.xerrors.@internal_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x
{
    public static partial class xerrors_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct wrapError
        {
            // Constructors
            public wrapError(NilType _)
            {
                this.msg = default;
                this.err = default;
                this.frame = default;
            }

            public wrapError(@string msg = default, error err = default, Frame frame = default)
            {
                this.msg = msg;
                this.err = err;
                this.frame = frame;
            }

            // Enable comparisons between nil and wrapError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(wrapError value, NilType nil) => value.Equals(default(wrapError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(wrapError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, wrapError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, wrapError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator wrapError(NilType nil) => default(wrapError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static wrapError wrapError_cast(dynamic value)
        {
            return new wrapError(value.msg, value.err, value.frame);
        }
    }
}}}