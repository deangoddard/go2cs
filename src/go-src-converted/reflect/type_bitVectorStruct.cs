//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:41:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct bitVector
        {
            // Constructors
            public bitVector(NilType _)
            {
                this.n = default;
                this.data = default;
            }

            public bitVector(uint n = default, slice<byte> data = default)
            {
                this.n = n;
                this.data = data;
            }

            // Enable comparisons between nil and bitVector struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(bitVector value, NilType nil) => value.Equals(default(bitVector));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(bitVector value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, bitVector value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, bitVector value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator bitVector(NilType nil) => default(bitVector);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static bitVector bitVector_cast(dynamic value)
        {
            return new bitVector(value.n, value.data);
        }
    }
}