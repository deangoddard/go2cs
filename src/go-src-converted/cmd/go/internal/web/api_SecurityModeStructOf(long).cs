//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:45:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class web_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SecurityMode
        {
            // Value of the SecurityMode struct
            private readonly long m_value;

            public SecurityMode(long value) => m_value = value;

            // Enable implicit conversions between long and SecurityMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SecurityMode(long value) => new SecurityMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(SecurityMode value) => value.m_value;
            
            // Enable comparisons between nil and SecurityMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SecurityMode value, NilType nil) => value.Equals(default(SecurityMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SecurityMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SecurityMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SecurityMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SecurityMode(NilType nil) => default(SecurityMode);
        }
    }
}}}}
