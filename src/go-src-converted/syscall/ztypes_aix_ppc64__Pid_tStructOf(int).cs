//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:04:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _Pid_t
        {
            // Value of the _Pid_t struct
            private readonly int m_value;

            public _Pid_t(int value) => m_value = value;

            // Enable implicit conversions between int and _Pid_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Pid_t(int value) => new _Pid_t(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator int(_Pid_t value) => value.m_value;
            
            // Enable comparisons between nil and _Pid_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_Pid_t value, NilType nil) => value.Equals(default(_Pid_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_Pid_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _Pid_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _Pid_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _Pid_t(NilType nil) => default(_Pid_t);
        }
    }
}
