//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace @internal {
namespace @event
{
    public static partial class label_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct list
        {
            // Constructors
            public list(NilType _)
            {
                this.labels = default;
            }

            public list(slice<Label> labels = default)
            {
                this.labels = labels;
            }

            // Enable comparisons between nil and list struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(list value, NilType nil) => value.Equals(default(list));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(list value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, list value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, list value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator list(NilType nil) => default(list);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static list list_cast(dynamic value)
        {
            return new list(value.labels);
        }
    }
}}}}}}