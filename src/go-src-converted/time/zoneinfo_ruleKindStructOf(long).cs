//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:06:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class time_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ruleKind
        {
            // Value of the ruleKind struct
            private readonly long m_value;

            public ruleKind(long value) => m_value = value;

            // Enable implicit conversions between long and ruleKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ruleKind(long value) => new ruleKind(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(ruleKind value) => value.m_value;
            
            // Enable comparisons between nil and ruleKind struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ruleKind value, NilType nil) => value.Equals(default(ruleKind));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ruleKind value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ruleKind value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ruleKind value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ruleKind(NilType nil) => default(ruleKind);
        }
    }
}
