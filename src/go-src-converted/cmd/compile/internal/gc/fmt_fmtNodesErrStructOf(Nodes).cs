//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:41:29 UTC
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
        private partial struct fmtNodesErr
        {
            // Value of the fmtNodesErr struct
            private readonly Nodes m_value;

            public fmtNodesErr(Nodes value) => m_value = value;

            // Enable implicit conversions between Nodes and fmtNodesErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodesErr(Nodes value) => new fmtNodesErr(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Nodes(fmtNodesErr value) => value.m_value;
            
            // Enable comparisons between nil and fmtNodesErr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fmtNodesErr value, NilType nil) => value.Equals(default(fmtNodesErr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fmtNodesErr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fmtNodesErr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fmtNodesErr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fmtNodesErr(NilType nil) => default(fmtNodesErr);
        }
    }
}}}}
