//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:16:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace runtime {
namespace @internal
{
    public static partial class sys_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Uintreg
        {
            // Value of the Uintreg struct
            private readonly ulong m_value;

            public Uintreg(ulong value) => m_value = value;

            // Enable implicit conversions between ulong and Uintreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Uintreg(ulong value) => new Uintreg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ulong(Uintreg value) => value.m_value;
            
            // Enable comparisons between nil and Uintreg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Uintreg value, NilType nil) => value.Equals(default(Uintreg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Uintreg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Uintreg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Uintreg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Uintreg(NilType nil) => default(Uintreg);
        }
    }
}}}
