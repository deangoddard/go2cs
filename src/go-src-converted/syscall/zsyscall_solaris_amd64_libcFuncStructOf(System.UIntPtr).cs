//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 22:29:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct libcFunc
        {
            // Value of the libcFunc struct
            private readonly System.UIntPtr m_value;
            
            public libcFunc(System.UIntPtr value) => m_value = value;

            // Enable implicit conversions between System.UIntPtr and libcFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator libcFunc(System.UIntPtr value) => new libcFunc(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator System.UIntPtr(libcFunc value) => value.m_value;
            
            // Enable comparisons between nil and libcFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(libcFunc value, NilType nil) => value.Equals(default(libcFunc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(libcFunc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, libcFunc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, libcFunc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator libcFunc(NilType nil) => default(libcFunc);
        }
    }
}
