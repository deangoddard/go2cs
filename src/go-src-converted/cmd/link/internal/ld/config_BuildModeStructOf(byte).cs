//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:02:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BuildMode
        {
            // Value of the BuildMode struct
            private readonly byte m_value;

            public BuildMode(byte value) => m_value = value;

            // Enable implicit conversions between byte and BuildMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildMode(byte value) => new BuildMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(BuildMode value) => value.m_value;
            
            // Enable comparisons between nil and BuildMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BuildMode value, NilType nil) => value.Equals(default(BuildMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BuildMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BuildMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BuildMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildMode(NilType nil) => default(BuildMode);
        }
    }
}}}}
