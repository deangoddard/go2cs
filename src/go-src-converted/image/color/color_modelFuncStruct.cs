//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:36 UTC
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
namespace image
{
    public static partial class color_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct modelFunc
        {
            // Constructors
            public modelFunc(NilType _)
            {
                this.f = default;
            }

            public modelFunc(Func<Color, Color> f = default)
            {
                this.f = f;
            }

            // Enable comparisons between nil and modelFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(modelFunc value, NilType nil) => value.Equals(default(modelFunc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(modelFunc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, modelFunc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, modelFunc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator modelFunc(NilType nil) => default(modelFunc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static modelFunc modelFunc_cast(dynamic value)
        {
            return new modelFunc(value.f);
        }
    }
}}