//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:15:00 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using math = go.math_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tableEntry
        {
            // Constructors
            public tableEntry(NilType _)
            {
                this.val = default;
                this.offset = default;
            }

            public tableEntry(uint val = default, int offset = default)
            {
                this.val = val;
                this.offset = offset;
            }

            // Enable comparisons between nil and tableEntry struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tableEntry value, NilType nil) => value.Equals(default(tableEntry));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tableEntry value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tableEntry value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tableEntry value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tableEntry(NilType nil) => default(tableEntry);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tableEntry tableEntry_cast(dynamic value)
        {
            return new tableEntry(value.val, value.offset);
        }
    }
}}