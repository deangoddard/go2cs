//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:42:14 UTC
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
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct byStackVar
        {
            // Value of the byStackVar struct
            private readonly slice<ptr<Node>> m_value;

            public byStackVar(slice<ptr<Node>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Node>> and byStackVar struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byStackVar(slice<ptr<Node>> value) => new byStackVar(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Node>>(byStackVar value) => value.m_value;
            
            // Enable comparisons between nil and byStackVar struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(byStackVar value, NilType nil) => value.Equals(default(byStackVar));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(byStackVar value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, byStackVar value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, byStackVar value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byStackVar(NilType nil) => default(byStackVar);
        }
    }
}}}}
