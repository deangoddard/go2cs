//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:16:05 UTC
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
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct binaryBigEndian
        {
            // Constructors
            public binaryBigEndian(NilType _)
            {
            }
            // Enable comparisons between nil and binaryBigEndian struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(binaryBigEndian value, NilType nil) => value.Equals(default(binaryBigEndian));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(binaryBigEndian value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, binaryBigEndian value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, binaryBigEndian value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator binaryBigEndian(NilType nil) => default(binaryBigEndian);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static binaryBigEndian binaryBigEndian_cast(dynamic value)
        {
            return new binaryBigEndian();
        }
    }
}}}}