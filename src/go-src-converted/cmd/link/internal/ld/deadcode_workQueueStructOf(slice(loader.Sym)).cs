//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:49:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct workQueue
        {
            // Value of the workQueue struct
            private readonly slice<loader.Sym> m_value;

            public workQueue(slice<loader.Sym> value) => m_value = value;

            // Enable implicit conversions between slice<loader.Sym> and workQueue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator workQueue(slice<loader.Sym> value) => new workQueue(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<loader.Sym>(workQueue value) => value.m_value;
            
            // Enable comparisons between nil and workQueue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(workQueue value, NilType nil) => value.Equals(default(workQueue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(workQueue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, workQueue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, workQueue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator workQueue(NilType nil) => default(workQueue);
        }
    }
}}}}
