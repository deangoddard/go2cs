//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:48:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class get_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ModuleMode
        {
            // Value of the ModuleMode struct
            private readonly long m_value;

            public ModuleMode(long value) => m_value = value;

            // Enable implicit conversions between long and ModuleMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ModuleMode(long value) => new ModuleMode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(ModuleMode value) => value.m_value;
            
            // Enable comparisons between nil and ModuleMode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ModuleMode value, NilType nil) => value.Equals(default(ModuleMode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ModuleMode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ModuleMode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ModuleMode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ModuleMode(NilType nil) => default(ModuleMode);
        }
    }
}}}}
