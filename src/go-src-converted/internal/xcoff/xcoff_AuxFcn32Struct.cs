//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:18:43 UTC
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
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct AuxFcn32
        {
            // Constructors
            public AuxFcn32(NilType _)
            {
                this.Xexptr = default;
                this.Xfsize = default;
                this.Xlnnoptr = default;
                this.Xendndx = default;
                this.Xpad = default;
            }

            public AuxFcn32(uint Xexptr = default, uint Xfsize = default, uint Xlnnoptr = default, uint Xendndx = default, ushort Xpad = default)
            {
                this.Xexptr = Xexptr;
                this.Xfsize = Xfsize;
                this.Xlnnoptr = Xlnnoptr;
                this.Xendndx = Xendndx;
                this.Xpad = Xpad;
            }

            // Enable comparisons between nil and AuxFcn32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(AuxFcn32 value, NilType nil) => value.Equals(default(AuxFcn32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(AuxFcn32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, AuxFcn32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, AuxFcn32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator AuxFcn32(NilType nil) => default(AuxFcn32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static AuxFcn32 AuxFcn32_cast(dynamic value)
        {
            return new AuxFcn32(value.Xexptr, value.Xfsize, value.Xlnnoptr, value.Xendndx, value.Xpad);
        }
    }
}}