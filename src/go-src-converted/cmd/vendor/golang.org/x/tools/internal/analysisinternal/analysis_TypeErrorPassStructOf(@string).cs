//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:05:05 UTC
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
namespace tools {
namespace @internal
{
    public static partial class analysisinternal_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TypeErrorPass
        {
            // Value of the TypeErrorPass struct
            private readonly @string m_value;

            public TypeErrorPass(@string value) => m_value = value;

            // Enable implicit conversions between @string and TypeErrorPass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeErrorPass(@string value) => new TypeErrorPass(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(TypeErrorPass value) => value.m_value;
            
            // Enable comparisons between nil and TypeErrorPass struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TypeErrorPass value, NilType nil) => value.Equals(default(TypeErrorPass));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TypeErrorPass value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TypeErrorPass value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TypeErrorPass value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TypeErrorPass(NilType nil) => default(TypeErrorPass);
        }
    }
}}}}}}}
