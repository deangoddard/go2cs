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
        private partial struct fieldParameters
        {
            // Constructors
            public fieldParameters(NilType _)
            {
                this.optional = default;
                this.@explicit = default;
                this.application = default;
                this.@private = default;
                this.defaultValue = default;
                this.tag = default;
                this.stringType = default;
                this.timeType = default;
                this.set = default;
                this.omitEmpty = default;
            }

            public fieldParameters(bool optional = default, bool @explicit = default, bool application = default, bool @private = default, ref ptr<long> defaultValue = default, ref ptr<long> tag = default, long stringType = default, long timeType = default, bool set = default, bool omitEmpty = default)
            {
                this.optional = optional;
                this.@explicit = @explicit;
                this.application = application;
                this.@private = @private;
                this.defaultValue = defaultValue;
                this.tag = tag;
                this.stringType = stringType;
                this.timeType = timeType;
                this.set = set;
                this.omitEmpty = omitEmpty;
            }

            // Enable comparisons between nil and fieldParameters struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fieldParameters value, NilType nil) => value.Equals(default(fieldParameters));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fieldParameters value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fieldParameters value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fieldParameters value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fieldParameters(NilType nil) => default(fieldParameters);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fieldParameters fieldParameters_cast(dynamic value)
        {
            return new fieldParameters(value.optional, value.@explicit, value.application, value.@private, ref value.defaultValue, ref value.tag, value.stringType, value.timeType, value.set, value.omitEmpty);
        }
    }
}}