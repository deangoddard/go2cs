//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:11:47 UTC
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
using utf8 = go.unicode.utf8_package;
using bidirule = go.golang_org.x.text.secure.bidirule_package;
using bidi = go.golang_org.x.text.unicode.bidi_package;
using norm = go.golang_org.x.text.unicode.norm_package;
using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace net
{
    public static partial class idna_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct labelIter
        {
            // Constructors
            public labelIter(NilType _)
            {
                this.orig = default;
                this.slice = default;
                this.curStart = default;
                this.curEnd = default;
                this.i = default;
            }

            public labelIter(@string orig = default, slice<@string> slice = default, long curStart = default, long curEnd = default, long i = default)
            {
                this.orig = orig;
                this.slice = slice;
                this.curStart = curStart;
                this.curEnd = curEnd;
                this.i = i;
            }

            // Enable comparisons between nil and labelIter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(labelIter value, NilType nil) => value.Equals(default(labelIter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(labelIter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, labelIter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, labelIter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator labelIter(NilType nil) => default(labelIter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static labelIter labelIter_cast(dynamic value)
        {
            return new labelIter(value.orig, value.slice, value.curStart, value.curEnd, value.i);
        }
    }
}}}}}