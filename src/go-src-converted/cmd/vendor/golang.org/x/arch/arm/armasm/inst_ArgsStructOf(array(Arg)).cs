//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:25 UTC
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
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Args
        {
            // Value of the Args struct
            private readonly array<Arg> m_value;

            public Args(array<Arg> value) => m_value = value;

            // Enable implicit conversions between array<Arg> and Args struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Args(array<Arg> value) => new Args(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<Arg>(Args value) => value.m_value;
            
            // Enable comparisons between nil and Args struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Args value, NilType nil) => value.Equals(default(Args));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Args value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Args value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Args value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Args(NilType nil) => default(Args);
        }
    }
}}}}}}}
