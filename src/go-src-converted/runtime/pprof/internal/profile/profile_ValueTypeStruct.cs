//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:24:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gzip = go.compress.gzip_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using regexp = go.regexp_package;
using strings = go.strings_package;
using time = go.time_package;
using go;

namespace go {
namespace runtime {
namespace pprof {
namespace @internal
{
    public static partial class profile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ValueType
        {
            // Constructors
            public ValueType(NilType _)
            {
                this.Type = default;
                this.Unit = default;
                this.typeX = default;
                this.unitX = default;
            }

            public ValueType(@string Type = default, @string Unit = default, long typeX = default, long unitX = default)
            {
                this.Type = Type;
                this.Unit = Unit;
                this.typeX = typeX;
                this.unitX = unitX;
            }

            // Enable comparisons between nil and ValueType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ValueType value, NilType nil) => value.Equals(default(ValueType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ValueType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ValueType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ValueType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ValueType(NilType nil) => default(ValueType);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ValueType ValueType_cast(dynamic value)
        {
            return new ValueType(value.Type, value.Unit, value.typeX, value.unitX);
        }
    }
}}}}