//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:56:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

#nullable enable

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2sortPriorityNodeSiblings
        {
            // Value of the http2sortPriorityNodeSiblings struct
            private readonly slice<ptr<http2priorityNode>> m_value;

            public http2sortPriorityNodeSiblings(slice<ptr<http2priorityNode>> value) => m_value = value;

            // Enable implicit conversions between slice<ptr<http2priorityNode>> and http2sortPriorityNodeSiblings struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2sortPriorityNodeSiblings(slice<ptr<http2priorityNode>> value) => new http2sortPriorityNodeSiblings(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<ptr<http2priorityNode>>(http2sortPriorityNodeSiblings value) => value.m_value;
            
            // Enable comparisons between nil and http2sortPriorityNodeSiblings struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2sortPriorityNodeSiblings value, NilType nil) => value.Equals(default(http2sortPriorityNodeSiblings));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2sortPriorityNodeSiblings value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2sortPriorityNodeSiblings value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2sortPriorityNodeSiblings value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2sortPriorityNodeSiblings(NilType nil) => default(http2sortPriorityNodeSiblings);
        }
    }
}}
