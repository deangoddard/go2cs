//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:43:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class reflect_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct StructTag
        {
            // Value of the StructTag struct
            private readonly @string m_value;

            public StructTag(@string value) => m_value = value;

            // Enable implicit conversions between @string and StructTag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StructTag(@string value) => new StructTag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(StructTag value) => value.m_value;
            
            // Enable comparisons between nil and StructTag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StructTag value, NilType nil) => value.Equals(default(StructTag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StructTag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StructTag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StructTag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StructTag(NilType nil) => default(StructTag);
        }
    }
}
