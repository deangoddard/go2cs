//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:02:45 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go {
namespace @internal
{
    public static partial class p_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Error
        {
            // Value of the Error struct
            private readonly error m_value;

            public Error(error value) => m_value = value;

            // Enable implicit conversions between error and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(error value) => new Error(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator error(Error value) => value.m_value;
            
            // Enable comparisons between nil and Error struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Error value, NilType nil) => value.Equals(default(Error));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Error value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Error value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Error value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Error(NilType nil) => default(Error);
        }
    }
}}}
