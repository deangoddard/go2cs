//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:10:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using errors = go.errors_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace database {
namespace sql
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NamedValue
        {
            // Constructors
            public NamedValue(NilType _)
            {
                this.Name = default;
                this.Ordinal = default;
                this.Value = default;
            }

            public NamedValue(@string Name = default, long Ordinal = default, Value Value = default)
            {
                this.Name = Name;
                this.Ordinal = Ordinal;
                this.Value = Value;
            }

            // Enable comparisons between nil and NamedValue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NamedValue value, NilType nil) => value.Equals(default(NamedValue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NamedValue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NamedValue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NamedValue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NamedValue(NilType nil) => default(NamedValue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NamedValue NamedValue_cast(dynamic value)
        {
            return new NamedValue(value.Name, value.Ordinal, value.Value);
        }
    }
}}}