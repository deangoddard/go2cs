//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2022 March 06 23:35:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using sort = go.sort_package;
using go;

#nullable enable

namespace go {
namespace compress
{
    public static partial class bzip2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct huffmanTree
        {
            // Constructors
            public huffmanTree(NilType _)
            {
                this.nodes = default;
                this.nextNode = default;
            }

            public huffmanTree(slice<huffmanNode> nodes = default, nint nextNode = default)
            {
                this.nodes = nodes;
                this.nextNode = nextNode;
            }

            // Enable comparisons between nil and huffmanTree struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(huffmanTree value, NilType nil) => value.Equals(default(huffmanTree));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(huffmanTree value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, huffmanTree value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, huffmanTree value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator huffmanTree(NilType nil) => default(huffmanTree);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static huffmanTree huffmanTree_cast(dynamic value)
        {
            return new huffmanTree(value.nodes, value.nextNode);
        }
    }
}}