//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 05:52:40 UTC
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
namespace go
{
    public static partial class e_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct U4
        {
            // Constructors
            public U4(NilType _)
            {
                this.ptr<u5> = default;
            }

            public U4(ref ptr<u5> ptr<u5> = default)
            {
                this.ptr<u5> = ptr<u5>;
            }

            // Enable comparisons between nil and U4 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(U4 value, NilType nil) => value.Equals(default(U4));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(U4 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, U4 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, U4 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator U4(NilType nil) => default(U4);
        }

        [GeneratedCode("go2cs", "0.1.2.0")]
        public static U4 U4_cast(dynamic value)
        {
            return new U4(ref value.ptr<u5>);
        }
    }
}}