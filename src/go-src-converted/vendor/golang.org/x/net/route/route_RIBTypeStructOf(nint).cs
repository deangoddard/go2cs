//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 13 06:46:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.2.0")]
        public partial struct RIBType
        {
            // Value of the RIBType struct
            private readonly nint m_value;
            
            public RIBType(nint value) => m_value = value;

            // Enable implicit conversions between nint and RIBType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RIBType(nint value) => new RIBType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nint(RIBType value) => value.m_value;
            
            // Enable comparisons between nil and RIBType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RIBType value, NilType nil) => value.Equals(default(RIBType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RIBType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RIBType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RIBType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RIBType(NilType nil) => default(RIBType);
        }
    }
}}}}}
