//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:38:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using list = go.container.list_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
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
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct bracketPairer
        {
            // Constructors
            public bracketPairer(NilType _)
            {
                this.sos = default;
                this.openers = default;
                this.pairPositions = default;
                this.codesIsolatedRun = default;
                this.indexes = default;
            }

            public bracketPairer(Class sos = default, ref ptr<list.List> openers = default, bracketPairs pairPositions = default, slice<Class> codesIsolatedRun = default, slice<nint> indexes = default)
            {
                this.sos = sos;
                this.openers = openers;
                this.pairPositions = pairPositions;
                this.codesIsolatedRun = codesIsolatedRun;
                this.indexes = indexes;
            }

            // Enable comparisons between nil and bracketPairer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bracketPairer value, NilType nil) => value.Equals(default(bracketPairer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bracketPairer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bracketPairer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bracketPairer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bracketPairer(NilType nil) => default(bracketPairer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static bracketPairer bracketPairer_cast(dynamic value)
        {
            return new bracketPairer(value.sos, ref value.openers, value.pairPositions, value.codesIsolatedRun, value.indexes);
        }
    }
}}}}}}