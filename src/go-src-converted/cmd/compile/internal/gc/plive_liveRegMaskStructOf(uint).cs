//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct liveRegMask
        {
            // Value of the liveRegMask struct
            private readonly uint m_value;

            public liveRegMask(uint value) => m_value = value;

            // Enable implicit conversions between uint and liveRegMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator liveRegMask(uint value) => new liveRegMask(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(liveRegMask value) => value.m_value;
            
            // Enable comparisons between nil and liveRegMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(liveRegMask value, NilType nil) => value.Equals(default(liveRegMask));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(liveRegMask value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, liveRegMask value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, liveRegMask value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator liveRegMask(NilType nil) => default(liveRegMask);
        }
    }
}}}}
