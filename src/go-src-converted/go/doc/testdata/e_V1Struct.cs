//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:41:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct V1
        {
            // Constructors
            public V1(NilType _)
            {
                this.ptr<V2> = default;
                this.ptr<V5> = default;
            }

            public V1(ref ptr<V2> ptr<V2> = default, ref ptr<V5> ptr<V5> = default)
            {
                this.ptr<V2> = ptr<V2>;
                this.ptr<V5> = ptr<V5>;
            }

            // Enable comparisons between nil and V1 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(V1 value, NilType nil) => value.Equals(default(V1));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(V1 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, V1 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, V1 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator V1(NilType nil) => default(V1);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static V1 V1_cast(dynamic value)
        {
            return new V1(ref value.ptr<V2>, ref value.ptr<V5>);
        }
    }
}}