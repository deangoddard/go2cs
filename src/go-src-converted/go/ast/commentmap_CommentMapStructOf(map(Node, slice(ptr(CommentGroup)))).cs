//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:20:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace go
{
    public static partial class ast_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CommentMap
        {
            // Value of the CommentMap struct
            private readonly map<Node, slice<ptr<CommentGroup>>> m_value;

            public CommentMap(map<Node, slice<ptr<CommentGroup>>> value) => m_value = value;

            // Enable implicit conversions between map<Node, slice<ptr<CommentGroup>>> and CommentMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommentMap(map<Node, slice<ptr<CommentGroup>>> value) => new CommentMap(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator map<Node, slice<ptr<CommentGroup>>>(CommentMap value) => value.m_value;
            
            // Enable comparisons between nil and CommentMap struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CommentMap value, NilType nil) => value.Equals(default(CommentMap));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CommentMap value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CommentMap value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CommentMap value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CommentMap(NilType nil) => default(CommentMap);
        }
    }
}}
