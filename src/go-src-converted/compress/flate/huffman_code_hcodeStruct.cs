//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:29:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using math = go.math_package;
using bits = go.math.bits_package;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct hcode
        {
            // Constructors
            public hcode(NilType _)
            {
                this.code = default;
                this.len = default;
            }

            public hcode(ushort code = default, ushort len = default)
            {
                this.code = code;
                this.len = len;
            }

            // Enable comparisons between nil and hcode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(hcode value, NilType nil) => value.Equals(default(hcode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(hcode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, hcode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, hcode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator hcode(NilType nil) => default(hcode);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static hcode hcode_cast(dynamic value)
        {
            return new hcode(value.code, value.len);
        }
    }
}}