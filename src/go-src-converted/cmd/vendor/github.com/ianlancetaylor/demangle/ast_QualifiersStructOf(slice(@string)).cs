//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:54:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace ianlancetaylor
{
    public static partial class demangle_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Qualifiers
        {
            // Value of the Qualifiers struct
            private readonly slice<@string> m_value;

            public Qualifiers(slice<@string> value) => m_value = value;

            // Enable implicit conversions between slice<@string> and Qualifiers struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Qualifiers(slice<@string> value) => new Qualifiers(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<@string>(Qualifiers value) => value.m_value;
            
            // Enable comparisons between nil and Qualifiers struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Qualifiers value, NilType nil) => value.Equals(default(Qualifiers));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Qualifiers value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Qualifiers value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Qualifiers value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Qualifiers(NilType nil) => default(Qualifiers);
        }
    }
}}}}}
