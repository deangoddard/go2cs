//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:22:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using go;

namespace go {
namespace runtime
{
    public static partial class pprof_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LabelSet
        {
            // Constructors
            public LabelSet(NilType _)
            {
                this.list = default;
            }

            public LabelSet(slice<label> list = default)
            {
                this.list = list;
            }

            // Enable comparisons between nil and LabelSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LabelSet value, NilType nil) => value.Equals(default(LabelSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LabelSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LabelSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LabelSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LabelSet(NilType nil) => default(LabelSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LabelSet LabelSet_cast(dynamic value)
        {
            return new LabelSet(value.list);
        }
    }
}}