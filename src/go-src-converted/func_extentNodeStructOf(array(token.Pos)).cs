//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:03:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct extentNode
        {
            // Value of the extentNode struct
            private readonly array<token.Pos> m_value;

            public extentNode(array<token.Pos> value) => m_value = value;

            // Enable implicit conversions between array<token.Pos> and extentNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator extentNode(array<token.Pos> value) => new extentNode(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<token.Pos>(extentNode value) => value.m_value;
            
            // Enable comparisons between nil and extentNode struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(extentNode value, NilType nil) => value.Equals(default(extentNode));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(extentNode value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, extentNode value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, extentNode value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator extentNode(NilType nil) => default(extentNode);
        }
    }
}}}}}
