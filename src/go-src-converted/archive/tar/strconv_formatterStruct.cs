//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:31:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

#nullable enable

namespace go {
namespace archive
{
    public static partial class tar_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct formatter
        {
            // Constructors
            public formatter(NilType _)
            {
                this.err = default;
            }

            public formatter(error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and formatter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(formatter value, NilType nil) => value.Equals(default(formatter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(formatter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, formatter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, formatter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator formatter(NilType nil) => default(formatter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static formatter formatter_cast(dynamic value)
        {
            return new formatter(value.err);
        }
    }
}}