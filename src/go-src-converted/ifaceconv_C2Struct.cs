//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct C2
        {
            // Constructors
            public C2(NilType _)
            {
            }
            // Enable comparisons between nil and C2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(C2 value, NilType nil) => value.Equals(default(C2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(C2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, C2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, C2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator C2(NilType nil) => default(C2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static C2 C2_cast(dynamic value)
        {
            return new C2();
        }
    }
}