//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:39:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using encoding = go.encoding_package;
using binary = go.encoding.binary_package;
using math = go.math_package;
using bits = go.math.bits_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

#nullable enable

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        private partial struct encEngine
        {
            // Constructors
            public encEngine(NilType _)
            {
                this.instr = default;
            }

            public encEngine(slice<encInstr> instr = default)
            {
                this.instr = instr;
            }

            // Enable comparisons between nil and encEngine struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encEngine value, NilType nil) => value.Equals(default(encEngine));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encEngine value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encEngine value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encEngine value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encEngine(NilType nil) => default(encEngine);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        private static encEngine encEngine_cast(dynamic value)
        {
            return new encEngine(value.instr);
        }
    }
}}