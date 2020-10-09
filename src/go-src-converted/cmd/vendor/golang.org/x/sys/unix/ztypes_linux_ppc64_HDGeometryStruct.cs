//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:39 UTC
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
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct HDGeometry
        {
            // Constructors
            public HDGeometry(NilType _)
            {
                this.Heads = default;
                this.Sectors = default;
                this.Cylinders = default;
                this.Start = default;
            }

            public HDGeometry(byte Heads = default, byte Sectors = default, ushort Cylinders = default, ulong Start = default)
            {
                this.Heads = Heads;
                this.Sectors = Sectors;
                this.Cylinders = Cylinders;
                this.Start = Start;
            }

            // Enable comparisons between nil and HDGeometry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(HDGeometry value, NilType nil) => value.Equals(default(HDGeometry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(HDGeometry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, HDGeometry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, HDGeometry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator HDGeometry(NilType nil) => default(HDGeometry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static HDGeometry HDGeometry_cast(dynamic value)
        {
            return new HDGeometry(value.Heads, value.Sectors, value.Cylinders, value.Start);
        }
    }
}}}}}}