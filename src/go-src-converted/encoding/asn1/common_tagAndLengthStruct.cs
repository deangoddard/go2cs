//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:54:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tagAndLength
        {
            // Constructors
            public tagAndLength(NilType _)
            {
                this.@class = default;
                this.tag = default;
                this.length = default;
                this.isCompound = default;
            }

            public tagAndLength(long @class = default, long tag = default, long length = default, bool isCompound = default)
            {
                this.@class = @class;
                this.tag = tag;
                this.length = length;
                this.isCompound = isCompound;
            }

            // Enable comparisons between nil and tagAndLength struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tagAndLength value, NilType nil) => value.Equals(default(tagAndLength));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tagAndLength value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tagAndLength value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tagAndLength value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tagAndLength(NilType nil) => default(tagAndLength);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tagAndLength tagAndLength_cast(dynamic value)
        {
            return new tagAndLength(value.@class, value.tag, value.length, value.isCompound);
        }
    }
}}