//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _Gid_t
        {
            // Value of the _Gid_t struct
            private readonly uint m_value;

            public _Gid_t(uint value) => m_value = value;

            // Enable implicit conversions between uint and _Gid_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Gid_t(uint value) => new _Gid_t(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(_Gid_t value) => value.m_value;
            
            // Enable comparisons between nil and _Gid_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Gid_t value, NilType nil) => value.Equals(default(_Gid_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Gid_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Gid_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Gid_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Gid_t(NilType nil) => default(_Gid_t);
        }
    }
}
