//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:58 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct IpMaskString
        {
            // Value of the IpMaskString struct
            private readonly IpAddressString m_value;

            public IpMaskString(IpAddressString value) => m_value = value;

            // Enable implicit conversions between IpAddressString and IpMaskString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpMaskString(IpAddressString value) => new IpMaskString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpAddressString(IpMaskString value) => value.m_value;
            
            // Enable comparisons between nil and IpMaskString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IpMaskString value, NilType nil) => value.Equals(default(IpMaskString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IpMaskString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IpMaskString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IpMaskString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator IpMaskString(NilType nil) => default(IpMaskString);
        }
    }
}}}}}}
