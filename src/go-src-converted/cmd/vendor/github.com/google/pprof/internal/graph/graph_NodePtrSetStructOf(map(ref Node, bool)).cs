//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class graph_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct NodePtrSet
        {
            // Value of the NodePtrSet struct
            private readonly map<ref Node, bool> m_value;

            public NodePtrSet(map<ref Node, bool> value) => m_value = value;

            // Enable implicit conversions between map<ref Node, bool> and NodePtrSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NodePtrSet(map<ref Node, bool> value) => new NodePtrSet(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<ref Node, bool>(NodePtrSet value) => value.m_value;
            
            // Enable comparisons between nil and NodePtrSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NodePtrSet value, NilType nil) => value.Equals(default(NodePtrSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NodePtrSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NodePtrSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NodePtrSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NodePtrSet(NilType nil) => default(NodePtrSet);
        }
    }
}}}}}}}
