//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:24:16 UTC
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
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Funarg
        {
            // Value of the Funarg struct
            private readonly byte m_value;

            public Funarg(byte value) => m_value = value;

            // Enable implicit conversions between byte and Funarg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Funarg(byte value) => new Funarg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Funarg value) => value.m_value;
            
            // Enable comparisons between nil and Funarg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Funarg value, NilType nil) => value.Equals(default(Funarg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Funarg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Funarg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Funarg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Funarg(NilType nil) => default(Funarg);
        }
    }
}}}}
