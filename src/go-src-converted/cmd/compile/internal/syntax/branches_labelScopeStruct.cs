//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:40:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct labelScope
        {
            // Constructors
            public labelScope(NilType _)
            {
                this.errh = default;
                this.labels = default;
            }

            public labelScope(ErrorHandler errh = default, map<@string, ptr<label>> labels = default)
            {
                this.errh = errh;
                this.labels = labels;
            }

            // Enable comparisons between nil and labelScope struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(labelScope value, NilType nil) => value.Equals(default(labelScope));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(labelScope value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, labelScope value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, labelScope value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator labelScope(NilType nil) => default(labelScope);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static labelScope labelScope_cast(dynamic value)
        {
            return new labelScope(value.errh, value.labels);
        }
    }
}}}}