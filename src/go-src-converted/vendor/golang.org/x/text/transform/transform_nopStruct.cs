//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using utf8 = go.unicode.utf8_package;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace text
{
    public static partial class transform_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        [PromotedStruct(typeof(NopResetter))]
        private partial struct nop
        {
            // NopResetter structure promotion - sourced from value copy
            private readonly ptr<NopResetter> m_NopResetterRef;

            private ref NopResetter NopResetter_val => ref m_NopResetterRef.Value;

            // Constructors
            public nop(NilType _)
            {
                this.m_NopResetterRef = new ptr<NopResetter>(new NopResetter(nil));
            }

            public nop(NopResetter NopResetter = default)
            {
                this.m_NopResetterRef = new ptr<NopResetter>(NopResetter);
            }

            // Enable comparisons between nil and nop struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nop value, NilType nil) => value.Equals(default(nop));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nop value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nop value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nop value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nop(NilType nil) => default(nop);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static nop nop_cast(dynamic value)
        {
            return new nop(value.NopResetter);
        }
    }
}}}}}