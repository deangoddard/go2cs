//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using unsafeheader = go.@internal.unsafeheader_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using @unsafe = go.@unsafe_package;

#nullable enable

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct name
        {
            // Constructors
            public name(NilType _)
            {
                this.bytes = default;
            }

            public name(ref ptr<byte> bytes = default)
            {
                this.bytes = bytes;
            }

            // Enable comparisons between nil and name struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(name value, NilType nil) => value.Equals(default(name));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(name value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, name value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, name value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator name(NilType nil) => default(name);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static name name_cast(dynamic value)
        {
            return new name(ref value.bytes);
        }
    }
}