//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:20:43 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using _@unsafe_ = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noteData
        {
            // Constructors
            public noteData(NilType _)
            {
                this.s = default;
                this.n = default;
            }

            public noteData(array<byte> s = default, long n = default)
            {
                this.s = s;
                this.n = n;
            }

            // Enable comparisons between nil and noteData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noteData value, NilType nil) => value.Equals(default(noteData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noteData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noteData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noteData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noteData(NilType nil) => default(noteData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noteData noteData_cast(dynamic value)
        {
            return new noteData(value.s, value.n);
        }
    }
}