//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:09:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace image
{
    public static partial class color_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Gray16
        {
            // Constructors
            public Gray16(NilType _)
            {
                this.Y = default;
            }

            public Gray16(ushort Y = default)
            {
                this.Y = Y;
            }

            // Enable comparisons between nil and Gray16 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Gray16 value, NilType nil) => value.Equals(default(Gray16));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Gray16 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Gray16 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Gray16 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Gray16(NilType nil) => default(Gray16);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Gray16 Gray16_cast(dynamic value)
        {
            return new Gray16(value.Y);
        }
    }
}}