//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:53:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct functionKey
        {
            // Constructors
            public functionKey(NilType _)
            {
                this.startLine = default;
                this.name = default;
                this.systemName = default;
                this.fileName = default;
            }

            public functionKey(long startLine = default, @string name = default, @string systemName = default, @string fileName = default)
            {
                this.startLine = startLine;
                this.name = name;
                this.systemName = systemName;
                this.fileName = fileName;
            }

            // Enable comparisons between nil and functionKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(functionKey value, NilType nil) => value.Equals(default(functionKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(functionKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, functionKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, functionKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator functionKey(NilType nil) => default(functionKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static functionKey functionKey_cast(dynamic value)
        {
            return new functionKey(value.startLine, value.name, value.systemName, value.fileName);
        }
    }
}}}}}}