//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:53:39 UTC
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
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class graph_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Nodes
        {
            // Value of the Nodes struct
            private readonly slice<ptr<Node>> m_value;

            public Nodes(slice<ptr<Node>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<Node>> and Nodes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nodes(slice<ptr<Node>> value) => new Nodes(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<Node>>(Nodes value) => value.m_value;
            
            // Enable comparisons between nil and Nodes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Nodes value, NilType nil) => value.Equals(default(Nodes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Nodes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Nodes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Nodes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nodes(NilType nil) => default(Nodes);
        }
    }
}}}}}}}
