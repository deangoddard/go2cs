//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RenegotiationSupport
        {
            // Value of the RenegotiationSupport struct
            private readonly long m_value;

            public RenegotiationSupport(long value) => m_value = value;

            // Enable implicit conversions between long and RenegotiationSupport struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RenegotiationSupport(long value) => new RenegotiationSupport(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(RenegotiationSupport value) => value.m_value;
            
            // Enable comparisons between nil and RenegotiationSupport struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RenegotiationSupport value, NilType nil) => value.Equals(default(RenegotiationSupport));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RenegotiationSupport value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RenegotiationSupport value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RenegotiationSupport value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RenegotiationSupport(NilType nil) => default(RenegotiationSupport);
        }
    }
}}
