//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct N
        {
            // Value of the N struct
            private readonly System.Numerics.Complex128 m_value;

            public N(System.Numerics.Complex128 value) => m_value = value;

            // Enable implicit conversions between System.Numerics.Complex128 and N struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator N(System.Numerics.Complex128 value) => new N(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.Numerics.Complex128(N value) => value.m_value;
            
            // Enable comparisons between nil and N struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(N value, NilType nil) => value.Equals(default(N));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(N value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, N value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, N value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator N(NilType nil) => default(N);
        }
    }
}
