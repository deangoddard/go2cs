//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:27:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace @internal
{
    public static partial class unsafeheader_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct Slice
        {
            // Constructors
            public Slice(NilType _)
            {
                this.Data = default;
                this.Len = default;
                this.Cap = default;
            }

            public Slice(unsafe.Pointer Data = default, nint Len = default, nint Cap = default)
            {
                this.Data = Data;
                this.Len = Len;
                this.Cap = Cap;
            }

            // Enable comparisons between nil and Slice struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Slice value, NilType nil) => value.Equals(default(Slice));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Slice value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Slice value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Slice value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Slice(NilType nil) => default(Slice);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static Slice Slice_cast(dynamic value)
        {
            return new Slice(value.Data, value.Len, value.Cap);
        }
    }
}}