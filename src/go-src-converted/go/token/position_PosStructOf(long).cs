//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:46:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace go
{
    public static partial class token_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Pos
        {
            // Value of the Pos struct
            private readonly long m_value;

            public Pos(long value) => m_value = value;

            // Enable implicit conversions between long and Pos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pos(long value) => new Pos(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Pos value) => value.m_value;
            
            // Enable comparisons between nil and Pos struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Pos value, NilType nil) => value.Equals(default(Pos));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Pos value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Pos value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Pos value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Pos(NilType nil) => default(Pos);
        }
    }
}}
