//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:10:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _Plink
        {
            // Value of the _Plink struct
            private readonly System.UIntPtr m_value;
            
            public _Plink(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and _Plink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Plink(System.UIntPtr value) => new _Plink(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(_Plink value) => value.m_value;
            
            // Enable comparisons between nil and _Plink struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Plink value, NilType nil) => value.Equals(default(_Plink));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Plink value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Plink value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Plink value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Plink(NilType nil) => default(_Plink);
        }
    }
}
