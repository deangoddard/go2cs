//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using rand = go.math.rand_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vet {
namespace testdata
{
    public static partial class assign_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ST
        {
            // Constructors
            public ST(NilType _)
            {
                this.x = default;
                this.l = default;
            }

            public ST(long x = default, slice<long> l = default)
            {
                this.x = x;
                this.l = l;
            }

            // Enable comparisons between nil and ST struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ST value, NilType nil) => value.Equals(default(ST));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ST value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ST value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ST value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ST(NilType nil) => default(ST);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ST ST_cast(dynamic value)
        {
            return new ST(value.x, value.l);
        }
    }
}}}}