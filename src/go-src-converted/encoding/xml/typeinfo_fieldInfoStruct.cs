//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:40:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct fieldInfo
        {
            // Constructors
            public fieldInfo(NilType _)
            {
                this.idx = default;
                this.name = default;
                this.xmlns = default;
                this.flags = default;
                this.parents = default;
            }

            public fieldInfo(slice<nint> idx = default, @string name = default, @string xmlns = default, fieldFlags flags = default, slice<@string> parents = default)
            {
                this.idx = idx;
                this.name = name;
                this.xmlns = xmlns;
                this.flags = flags;
                this.parents = parents;
            }

            // Enable comparisons between nil and fieldInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fieldInfo value, NilType nil) => value.Equals(default(fieldInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fieldInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fieldInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fieldInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fieldInfo(NilType nil) => default(fieldInfo);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static fieldInfo fieldInfo_cast(dynamic value)
        {
            return new fieldInfo(value.idx, value.name, value.xmlns, value.flags, value.parents);
        }
    }
}}