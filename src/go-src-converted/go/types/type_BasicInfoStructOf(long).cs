//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:19:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BasicInfo
        {
            // Value of the BasicInfo struct
            private readonly long m_value;

            public BasicInfo(long value) => m_value = value;

            // Enable implicit conversions between long and BasicInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BasicInfo(long value) => new BasicInfo(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(BasicInfo value) => value.m_value;
            
            // Enable comparisons between nil and BasicInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BasicInfo value, NilType nil) => value.Equals(default(BasicInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BasicInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BasicInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BasicInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BasicInfo(NilType nil) => default(BasicInfo);
        }
    }
}}
