//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:50:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct addrinfoErrno
        {
            // Value of the addrinfoErrno struct
            private readonly long m_value;

            public addrinfoErrno(long value) => m_value = value;

            // Enable implicit conversions between long and addrinfoErrno struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator addrinfoErrno(long value) => new addrinfoErrno(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(addrinfoErrno value) => value.m_value;
            
            // Enable comparisons between nil and addrinfoErrno struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(addrinfoErrno value, NilType nil) => value.Equals(default(addrinfoErrno));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(addrinfoErrno value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, addrinfoErrno value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, addrinfoErrno value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator addrinfoErrno(NilType nil) => default(addrinfoErrno);
        }
    }
}
