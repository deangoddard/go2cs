//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:32:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class gccgoimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fixupRecord
        {
            // Constructors
            public fixupRecord(NilType _)
            {
                this.toUpdate = default;
                this.target = default;
            }

            public fixupRecord(ref ptr<types.Named> toUpdate = default, types.Type target = default)
            {
                this.toUpdate = toUpdate;
                this.target = target;
            }

            // Enable comparisons between nil and fixupRecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fixupRecord value, NilType nil) => value.Equals(default(fixupRecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fixupRecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fixupRecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fixupRecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fixupRecord(NilType nil) => default(fixupRecord);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fixupRecord fixupRecord_cast(dynamic value)
        {
            return new fixupRecord(ref value.toUpdate, value.target);
        }
    }
}}}