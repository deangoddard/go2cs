//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:26 UTC
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
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dev_t
        {
            // Value of the dev_t struct
            private readonly uint m_value;

            public dev_t(uint value) => m_value = value;

            // Enable implicit conversions between uint and dev_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dev_t(uint value) => new dev_t(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(dev_t value) => value.m_value;
            
            // Enable comparisons between nil and dev_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dev_t value, NilType nil) => value.Equals(default(dev_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dev_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dev_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dev_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dev_t(NilType nil) => default(dev_t);
        }
    }
}}}}}}
