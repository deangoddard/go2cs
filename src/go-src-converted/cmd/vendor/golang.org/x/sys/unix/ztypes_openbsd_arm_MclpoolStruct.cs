//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:46 UTC
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
        public partial struct Mclpool
        {
            // Constructors
            public Mclpool(NilType _)
            {
            }
            // Enable comparisons between nil and Mclpool struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mclpool value, NilType nil) => value.Equals(default(Mclpool));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mclpool value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mclpool value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mclpool value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mclpool(NilType nil) => default(Mclpool);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Mclpool Mclpool_cast(dynamic value)
        {
            return new Mclpool();
        }
    }
}}}}}}