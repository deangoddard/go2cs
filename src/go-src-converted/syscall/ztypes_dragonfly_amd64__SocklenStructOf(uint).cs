//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:42:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _Socklen
        {
            // Value of the _Socklen struct
            private readonly uint m_value;

            public _Socklen(uint value) => m_value = value;

            // Enable implicit conversions between uint and _Socklen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Socklen(uint value) => new _Socklen(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(_Socklen value) => value.m_value;
            
            // Enable comparisons between nil and _Socklen struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Socklen value, NilType nil) => value.Equals(default(_Socklen));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Socklen value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Socklen value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Socklen value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Socklen(NilType nil) => default(_Socklen);
        }
    }
}
