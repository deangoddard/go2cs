//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:41 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using fmt = go.fmt_package;
using log = go.log_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct isolatingRunSequence
        {
            // Constructors
            public isolatingRunSequence(NilType _)
            {
                this.p = default;
                this.indexes = default;
                this.types = default;
                this.resolvedLevels = default;
                this.level = default;
                this.sos = default;
                this.eos = default;
            }

            public isolatingRunSequence(ref ptr<paragraph> p = default, slice<nint> indexes = default, slice<Class> types = default, slice<level> resolvedLevels = default, level level = default, Class sos = default, Class eos = default)
            {
                this.p = p;
                this.indexes = indexes;
                this.types = types;
                this.resolvedLevels = resolvedLevels;
                this.level = level;
                this.sos = sos;
                this.eos = eos;
            }

            // Enable comparisons between nil and isolatingRunSequence struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(isolatingRunSequence value, NilType nil) => value.Equals(default(isolatingRunSequence));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(isolatingRunSequence value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, isolatingRunSequence value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, isolatingRunSequence value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator isolatingRunSequence(NilType nil) => default(isolatingRunSequence);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static isolatingRunSequence isolatingRunSequence_cast(dynamic value)
        {
            return new isolatingRunSequence(ref value.p, value.indexes, value.types, value.resolvedLevels, value.level, value.sos, value.eos);
        }
    }
}}}}}}