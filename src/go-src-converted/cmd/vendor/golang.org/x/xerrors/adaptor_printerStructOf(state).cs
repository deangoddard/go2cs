//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:06 UTC
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
namespace x
{
    public static partial class xerrors_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct printer
        {
            // Value of the printer struct
            private readonly state m_value;

            public printer(state value) => m_value = value;

            // Enable implicit conversions between state and printer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator printer(state value) => new printer(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator state(printer value) => value.m_value;
            
            // Enable comparisons between nil and printer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(printer value, NilType nil) => value.Equals(default(printer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(printer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, printer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, printer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator printer(NilType nil) => default(printer);
        }
    }
}}}}}
