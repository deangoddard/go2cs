//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:12:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace vendor {
namespace golang_org {
namespace x {
namespace text {
namespace unicode
{
    public static partial class bidi_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Ordering
        {
            // Constructors
            public Ordering(NilType _)
            {
            }
            // Enable comparisons between nil and Ordering struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Ordering value, NilType nil) => value.Equals(default(Ordering));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Ordering value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Ordering value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Ordering value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Ordering(NilType nil) => default(Ordering);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Ordering Ordering_cast(dynamic value)
        {
            return new Ordering();
        }
    }
}}}}}}