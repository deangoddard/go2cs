//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byPkg
        {
            // Value of the byPkg struct
            private readonly slice<ptr<sym.Library>> m_value;

            public byPkg(slice<ptr<sym.Library>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<sym.Library>> and byPkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPkg(slice<ptr<sym.Library>> value) => new byPkg(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<sym.Library>>(byPkg value) => value.m_value;
            
            // Enable comparisons between nil and byPkg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byPkg value, NilType nil) => value.Equals(default(byPkg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byPkg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byPkg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byPkg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byPkg(NilType nil) => default(byPkg);
        }
    }
}}}}
