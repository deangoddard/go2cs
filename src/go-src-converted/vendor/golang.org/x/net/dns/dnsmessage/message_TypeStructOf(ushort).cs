//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:06:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net {
namespace dns
{
    public static partial class dnsmessage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Type
        {
            // Value of the Type struct
            private readonly ushort m_value;

            public Type(ushort value) => m_value = value;

            // Enable implicit conversions between ushort and Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Type(ushort value) => new Type(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ushort(Type value) => value.m_value;
            
            // Enable comparisons between nil and Type struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Type value, NilType nil) => value.Equals(default(Type));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Type value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Type value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Type value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Type(NilType nil) => default(Type);
        }
    }
}}}}}}
