//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dddSlice
        {
            // Constructors
            public dddSlice(NilType _)
            {
                this.elem = default;
            }

            public dddSlice(types.Type elem = default)
            {
                this.elem = elem;
            }

            // Enable comparisons between nil and dddSlice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dddSlice value, NilType nil) => value.Equals(default(dddSlice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dddSlice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dddSlice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dddSlice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dddSlice(NilType nil) => default(dddSlice);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dddSlice dddSlice_cast(dynamic value)
        {
            return new dddSlice(value.elem);
        }
    }
}}}}}}