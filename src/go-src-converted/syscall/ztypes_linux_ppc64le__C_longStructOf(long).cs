//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _C_long
        {
            // Value of the _C_long struct
            private readonly long m_value;

            public _C_long(long value) => m_value = value;

            // Enable implicit conversions between long and _C_long struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_long(long value) => new _C_long(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(_C_long value) => value.m_value;
            
            // Enable comparisons between nil and _C_long struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_C_long value, NilType nil) => value.Equals(default(_C_long));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_C_long value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _C_long value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _C_long value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_long(NilType nil) => default(_C_long);
        }
    }
}
