//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:25:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct P
        {
            // Value of the P struct
            private readonly @string m_value;
            
            public P(@string value) => m_value = value;

            // Enable implicit conversions between @string and P struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator P(@string value) => new P(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(P value) => value.m_value;
            
            // Enable comparisons between nil and P struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(P value, NilType nil) => value.Equals(default(P));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(P value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, P value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, P value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator P(NilType nil) => default(P);
        }
    }
}
