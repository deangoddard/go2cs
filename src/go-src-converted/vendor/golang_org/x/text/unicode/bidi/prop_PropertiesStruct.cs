//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:12:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Properties
        {
            // Constructors
            public Properties(NilType _)
            {
                this.entry = default;
                this.last = default;
            }

            public Properties(byte entry = default, byte last = default)
            {
                this.entry = entry;
                this.last = last;
            }

            // Enable comparisons between nil and Properties struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Properties value, NilType nil) => value.Equals(default(Properties));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Properties value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Properties value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Properties value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Properties(NilType nil) => default(Properties);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Properties Properties_cast(dynamic value)
        {
            return new Properties(value.entry, value.last);
        }
    }
}}}}}}