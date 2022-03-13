//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:28:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using math = go.math_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace runtime
{
    public static partial class metrics_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Value
        {
            // Constructors
            public Value(NilType _)
            {
                this.kind = default;
                this.scalar = default;
                this.pointer = default;
            }

            public Value(ValueKind kind = default, ulong scalar = default, unsafe.Pointer pointer = default)
            {
                this.kind = kind;
                this.scalar = scalar;
                this.pointer = pointer;
            }

            // Enable comparisons between nil and Value struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Value value, NilType nil) => value.Equals(default(Value));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Value value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Value value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Value value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Value(NilType nil) => default(Value);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Value Value_cast(dynamic value)
        {
            return new Value(value.kind, value.scalar, value.pointer);
        }
    }
}}